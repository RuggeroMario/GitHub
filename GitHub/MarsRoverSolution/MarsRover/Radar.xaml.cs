using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class Radar : Window
    {
        private Random _random;
        private RoverMachine _rover;

        public Radar()
        {
            InitializeComponent();
           
            _random = new Random();
            _rover = new RoverMachine();
            _rover.OverGridSize += _rover_OverGridSize;
            CreateMaps();          
        }

        void _rover_OverGridSize()
        {
            CreateMaps();
        }

        private void CreateMaps()
        {
            radarGrid.Children.Clear();
            for (int z = 0; z < this.radarGrid.ColumnDefinitions.Count; z++)
            {
                int x = _random.Next(1, this.radarGrid.ColumnDefinitions.Count);
                int y = _random.Next(1, this.radarGrid.RowDefinitions.Count);

                Mountain m = new Mountain();
                radarGrid.Children.Add(m);
                m.SetValue(Grid.ColumnProperty, x);
                m.SetValue(Grid.RowProperty, y);

                //_square[x, y] = 1;
            }

            radarGrid.Children.Add(_rover);
            _rover.SetPosition();
        }

        private void LocateRover()
        {
            _rover.SetPosition();
        }

        private void LocateButton_Click(object sender, RoutedEventArgs e)
        {
            LocateRover();
        }

        private void TurnToLeftButton_Click(object sender, RoutedEventArgs e)
        {
            _rover.TurnLeft();
        }

        private void TurnToRightButton_Click(object sender, RoutedEventArgs e)
        {
            _rover.TurnRight();
        }

        private void FollowTrackButton_Click(object sender, RoutedEventArgs e)
        {
            _rover.Track = Track.Text.Trim();
            _rover.FollowTrack();
        }
    }
}
