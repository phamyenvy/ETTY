﻿#pragma checksum "..\..\DetailVideo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93E7A507337E15BA48756DC65EC6EA7FFF1DEE54"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LTUDQL2_QUAN_LY_CCVIDEO;
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


namespace LTUDQL2_QUAN_LY_CCVIDEO {
    
    
    /// <summary>
    /// DetailVideo
    /// </summary>
    public partial class DetailVideo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\DetailVideo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement mediaVideo;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\DetailVideo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton btnPlayorPause;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\DetailVideo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTenVideo;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\DetailVideo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton btnHeart;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\DetailVideo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.RatingBar BasicRatingBar;
        
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
            System.Uri resourceLocater = new System.Uri("/LTUDQL2_QUAN_LY_CCVIDEO;component/detailvideo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DetailVideo.xaml"
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
            this.mediaVideo = ((System.Windows.Controls.MediaElement)(target));
            
            #line 28 "..\..\DetailVideo.xaml"
            this.mediaVideo.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.mediaVideo_MouseEnter);
            
            #line default
            #line hidden
            
            #line 29 "..\..\DetailVideo.xaml"
            this.mediaVideo.MouseLeave += new System.Windows.Input.MouseEventHandler(this.mediaVideo_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnPlayorPause = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 33 "..\..\DetailVideo.xaml"
            this.btnPlayorPause.Click += new System.Windows.RoutedEventHandler(this.btnPlayorPause_Click);
            
            #line default
            #line hidden
            
            #line 35 "..\..\DetailVideo.xaml"
            this.btnPlayorPause.MouseEnter += new System.Windows.Input.MouseEventHandler(this.mediaVideo_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblTenVideo = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.btnHeart = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 5:
            this.BasicRatingBar = ((MaterialDesignThemes.Wpf.RatingBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

