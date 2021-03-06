﻿#pragma checksum "..\..\Radar.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "872F5216B4A5BF6C09F5B345E2DF03DCCFFCDA8D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MarsRover {
    
    
    /// <summary>
    /// Radar
    /// </summary>
    public partial class Radar : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\Radar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid radarGrid;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Radar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LocateButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Radar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TurnToLeftButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Radar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TurnToRightButton;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Radar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Track;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Radar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SendTrackButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Radar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FollowTrackButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MarsRover;component/radar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Radar.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.radarGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.LocateButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\Radar.xaml"
            this.LocateButton.Click += new System.Windows.RoutedEventHandler(this.LocateButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TurnToLeftButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\Radar.xaml"
            this.TurnToLeftButton.Click += new System.Windows.RoutedEventHandler(this.TurnToLeftButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TurnToRightButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\Radar.xaml"
            this.TurnToRightButton.Click += new System.Windows.RoutedEventHandler(this.TurnToRightButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Track = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.SendTrackButton = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\Radar.xaml"
            this.SendTrackButton.Click += new System.Windows.RoutedEventHandler(this.SendTrackButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FollowTrackButton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\Radar.xaml"
            this.FollowTrackButton.Click += new System.Windows.RoutedEventHandler(this.FollowTrackButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

