﻿#pragma checksum "..\..\..\Views\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9619BDD1F7ED0329AC114B842796AD6EBB5BF639"
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
using LTUDQL2_QUAN_LY_CCVIDEO.Model;
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 123 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Content;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spMainVideo;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spMyList;
        
        #line default
        #line hidden
        
        
        #line 204 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spThinhHanh;
        
        #line default
        #line hidden
        
        
        #line 273 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spMoiNhat;
        
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
            System.Uri resourceLocater = new System.Uri("/LTUDQL2_QUAN_LY_CCVIDEO;component/views/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MainWindow.xaml"
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
            case 2:
            this.Content = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.spMainVideo = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.spMyList = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.spThinhHanh = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.spMoiNhat = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 1:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.MouseEnterEvent;
            
            #line 18 "..\..\..\Views\MainWindow.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseEventHandler(this.Grid_MouseEnter);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.MouseLeaveEvent;
            
            #line 19 "..\..\..\Views\MainWindow.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseEventHandler(this.Grid_MouseLeave);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 5:
            
            #line 146 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Scroll_MouseEnter);
            
            #line default
            #line hidden
            
            #line 147 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Scroll_MouseLeave);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 215 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Scroll_ThinhHanh_MouseEnter);
            
            #line default
            #line hidden
            
            #line 216 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Scroll_ThinhHanh_MouseLeave);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 284 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Scroll_MoiNhat_MouseEnter);
            
            #line default
            #line hidden
            
            #line 285 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Scroll_MoiNhat_MouseLeave);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

