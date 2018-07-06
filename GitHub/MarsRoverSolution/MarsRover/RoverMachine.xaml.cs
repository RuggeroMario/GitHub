using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MarsRover
{
    /// <summary>
    /// Logica di interazione per RoverMachine.xaml
    /// </summary>
    public partial class RoverMachine : UserControl
    {
        RotateTransform _rt;
        double _rotationAngle;
        Grid _grid;
        private Random _random;

        public delegate void OverGridSizeDelegate();
        public event OverGridSizeDelegate OverGridSize;

        public RoverMachine()
        {
            InitializeComponent();
            _rt = new RotateTransform();
            RotationAngle = CardinalPoints.Nord;
            _random = new Random();
            StopLightSwitch(StopLights.Off);
        }

        
        public void FollowTrack()
        {
            if (String.IsNullOrEmpty(this.Track))
                return;

            for (int z = 0; z < this.Track.Length; z++)
            {
                string command = this.Track.Substring(z, 1);
                if (command != String.Empty)
                {
                    switch (command)
                    { 
                        case DriveCommand.Forward:
                            if (!GoForward())
                            {
                                z = this.Track.Length;
                            }
                            break;
                        case DriveCommand.Back:
                            if (!GoBack())
                            {
                                z = this.Track.Length;
                            }
                            break;
                        case DriveCommand.Left: 
                            TurnLeft();
                            break;
                        case DriveCommand.Right:
                            TurnRight();
                            break;
                    }
                }
                
            }  
        }

        public void SetPosition()
        {
            _grid = this.Parent as Grid;
            if (_grid == null)
            { return; }

            int x =0;
            int y =0;

            UIElement element;
            int maxcell = _grid.RowDefinitions.Count * _grid.ColumnDefinitions.Count;
            for (int z = 0; z < maxcell; z++)
            {
                x = _random.Next(1, _grid.ColumnDefinitions.Count);
                y = _random.Next(1, _grid.RowDefinitions.Count);
                element = CheckContentCell(x, y);
                if (element == null)
                {   
                    this.SetValue(Grid.ColumnProperty, x);
                    this.SetValue(Grid.RowProperty, y);
                    StopLightSwitch(StopLights.Off);
                    z = maxcell;
                }
            }
        }

        private UIElement CheckContentCell(int x, int y)
        {
            return _grid.Children.Cast<UIElement>().FirstOrDefault(e => Grid.GetColumn(e) == x && Grid.GetRow(e) == y);
        }

        private bool GoForward()
        {
           return GoStraigth(StraigthDirection.Forward);
        }

        private bool GoBack()
        {
           return GoStraigth(StraigthDirection.Back);
        }

        private bool GoStraigth(int direction)
        {
            int row = (int)this.GetValue(Grid.RowProperty); 
            int column = (int)this.GetValue(Grid.ColumnProperty);
            double radians = RotationAngle * Math.PI / 180;
            int cos = (int)Math.Cos(radians);
            int sin = (int)Math.Sin(radians);
            bool result = false;

            cos *= direction;
            sin *= direction;

            if (row - cos < 0 || row - cos > _grid.RowDefinitions.Count || column + sin < 0 || column + sin > _grid.ColumnDefinitions.Count)
            {
                if (this.OverGridSize != null)
                {
                    this.OverGridSize();
                    return true;
                }
            }

            //if (row - cos < 0)
            //{
            //    cos = 0;
            //}

            //if (column + sin < 0)
            //{
            //    sin = 0;
            //}
            //if (row - cos > _grid.RowDefinitions.Count)
            //{
            //    cos = 0;
            //}
            //if (column + sin > _grid.ColumnDefinitions.Count)
            //{
            //    sin = 0;
            //}

            UIElement element = CheckContentCell(column + sin, row - cos);
            if (element == null)
            {
                StopLightSwitch(StopLights.Off);
                result = true;
                if (RotationAngle == CardinalPoints.Nord || RotationAngle == CardinalPoints.Sud)
                {
                    this.SetValue(Grid.RowProperty, row - cos);
                }
                else
                {
                    this.SetValue(Grid.ColumnProperty, column + sin);
                }
            }
            else
            {
                if (!Type.Equals(element, this))
                {
                    StopLightSwitch(StopLights.On);
                }
                
            }


            return result;
        }


        private void StopLightSwitch(int onOff)
        {
            switch(onOff)
            {
                case StopLights.On:
                    RoverDirectionIndicatorStop.Visibility = Visibility.Visible;
                    break;
                case StopLights.Off:
                    RoverDirectionIndicatorStop.Visibility = Visibility.Hidden;
                    break;
            }
            
        }

        public void TurnLeft()
        {            
            TurnRover(DriveDegrees.TurnToLeft);
        }

        public void TurnRight()
        {
            TurnRover(DriveDegrees.TurnToRigth);
        }

        private void TurnRover(double g)
        {
            RotationAngle += g;
            _rt.Angle = RotationAngle;
            RoverDirectionIndicator.RenderTransform = _rt;
            RoverDirectionIndicatorStop.RenderTransform = _rt;
            StopLightSwitch(StopLights.Off);
        }

        private double RotationAngle
        {
            get
            {
                return this._rotationAngle;
            }

            set
            {
                this._rotationAngle = value;
                if (Math.Abs(_rotationAngle) == 360)
                {
                    _rotationAngle = 0;
                }
                if (_rotationAngle < 0)
                {
                    _rotationAngle += 360;
                }
            }
        }
        public string Track { get; set; }
    }
}
