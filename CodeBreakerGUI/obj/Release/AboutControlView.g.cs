﻿#pragma checksum "..\..\AboutControlView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "696B509E065E8E11B51F151590DB0AB333F95BBA72D57D72B1DD8122ADBA1852"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Gat.Controls;
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


namespace Gat.Controls {
    
    
    /// <summary>
    /// AboutControlView
    /// </summary>
    public partial class AboutControlView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\AboutControlView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ApplicationLogo;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\AboutControlView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Title;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\AboutControlView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Description;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\AboutControlView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Version;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\AboutControlView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PublisherLogo;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\AboutControlView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Copyright;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\AboutControlView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink Hyperlink;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\AboutControlView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HyperlinkText;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\AboutControlView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AdditionalNotes;
        
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
            System.Uri resourceLocater = new System.Uri("/CodeBreaker;component/aboutcontrolview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AboutControlView.xaml"
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
            
            #line 7 "..\..\AboutControlView.xaml"
            ((Gat.Controls.AboutControlView)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.UserControl_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ApplicationLogo = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.Title = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.Description = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Version = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.PublisherLogo = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.Copyright = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Hyperlink = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 104 "..\..\AboutControlView.xaml"
            this.Hyperlink.RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.Link_RequestNavigate);
            
            #line default
            #line hidden
            return;
            case 9:
            this.HyperlinkText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.AdditionalNotes = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

