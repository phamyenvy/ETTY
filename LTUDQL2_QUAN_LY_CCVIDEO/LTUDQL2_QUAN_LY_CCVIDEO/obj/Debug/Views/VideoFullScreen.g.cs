﻿#pragma checksum "..\..\..\Views\VideoFullScreen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D4578F1D39436BD1F2C21DEAB55FC9522DBFFCEC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LTUDQL2_QUAN_LY_CCVIDEO.Views;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace LTUDQL2_QUAN_LY_CCVIDEO.Views {
    
    
    /// <summary>
    /// VideoFullScreen
    /// </summary>
    public partial class VideoFullScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Views\VideoFullScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement mediaVideo;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Views\VideoFullScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton btnPlayorPause;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Views\VideoFullScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.StatusBar stusBar;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Views\VideoFullScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblProgressStatus;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Views\VideoFullScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliderTime;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Views\VideoFullScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFullScreen;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Views\VideoFullScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExitFullScreen;
        
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
            System.Uri resourceLocater = new System.Uri("/LTUDQL2_QUAN_LY_CCVIDEO;component/views/videofullscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\VideoFullScreen.xaml"
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
            
            #line 14 "..\..\..\Views\VideoFullScreen.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Play_CanExecute);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\Views\VideoFullScreen.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Play_Executed);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\..\Views\VideoFullScreen.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Pause_CanExecute);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\Views\VideoFullScreen.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Pause_Executed);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 16 "..\..\..\Views\VideoFullScreen.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Stop_CanExecute);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\Views\VideoFullScreen.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Stop_Executed);
            
            #line default
            #line hidden
            return;
            case 4:
            this.mediaVideo = ((System.Windows.Controls.MediaElement)(target));
            
            #line 25 "..\..\..\Views\VideoFullScreen.xaml"
            this.mediaVideo.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.mediaVideo_MouseDown);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\Views\VideoFullScreen.xaml"
            this.mediaVideo.MouseLeave += new System.Windows.Input.MouseEventHandler(this.mediaVideo_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnPlayorPause = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 30 "..\..\..\Views\VideoFullScreen.xaml"
            this.btnPlayorPause.Click += new System.Windows.RoutedEventHandler(this.btnPlayorPause_Click);
            
            #line default
            #line hidden
            
            #line 32 "..\..\..\Views\VideoFullScreen.xaml"
            this.btnPlayorPause.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnPlayorPause_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 6:
            this.stusBar = ((System.Windows.Controls.Primitives.StatusBar)(target));
            
            #line 43 "..\..\..\Views\VideoFullScreen.xaml"
            this.stusBar.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnPlayorPause_MouseEnter);
            
            #line default
            #line hidden
            
            #line 44 "..\..\..\Views\VideoFullScreen.xaml"
            this.stusBar.MouseLeave += new System.Windows.Input.MouseEventHandler(this.mediaVideo_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lblProgressStatus = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.sliderTime = ((System.Windows.Controls.Slider)(target));
            
            #line 76 "..\..\..\Views\VideoFullScreen.xaml"
            this.sliderTime.AddHandler(System.Windows.Controls.Primitives.Thumb.DragStartedEvent, new System.Windows.Controls.Primitives.DragStartedEventHandler(this.sliderTime_DragStarted));
            
            #line default
            #line hidden
            
            #line 77 "..\..\..\Views\VideoFullScreen.xaml"
            this.sliderTime.AddHandler(System.Windows.Controls.Primitives.Thumb.DragCompletedEvent, new System.Windows.Controls.Primitives.DragCompletedEventHandler(this.sliderTime_DragCompleted));
            
            #line default
            #line hidden
            
            #line 78 "..\..\..\Views\VideoFullScreen.xaml"
            this.sliderTime.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.sliderTime_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnFullScreen = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\Views\VideoFullScreen.xaml"
            this.btnFullScreen.Click += new System.Windows.RoutedEventHandler(this.btnFullScreen_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnExitFullScreen = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\Views\VideoFullScreen.xaml"
            this.btnExitFullScreen.Click += new System.Windows.RoutedEventHandler(this.btnExitFullScreen_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

