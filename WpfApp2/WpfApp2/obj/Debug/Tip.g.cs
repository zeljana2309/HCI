﻿#pragma checksum "..\..\Tip.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BCF25271CD02C24C151C39640D0530AD22987910"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using WpfApp2;
using WpfApp2.Validacija;


namespace WpfApp2 {
    
    
    /// <summary>
    /// Tip
    /// </summary>
    public partial class Tip : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\Tip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tipID;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Tip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup popupID;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\Tip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tipIme;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\Tip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup popupIme;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\Tip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tipOpis;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\Tip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup popupOpis;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\Tip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/tip.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Tip.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.tipID = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\Tip.xaml"
            this.tipID.LostFocus += new System.Windows.RoutedEventHandler(this.tipID_LostFocus);
            
            #line default
            #line hidden
            
            #line 49 "..\..\Tip.xaml"
            this.tipID.GotFocus += new System.Windows.RoutedEventHandler(this.tipID_GotFocus);
            
            #line default
            #line hidden
            
            #line 49 "..\..\Tip.xaml"
            this.tipID.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.tipID_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 49 "..\..\Tip.xaml"
            this.tipID.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.popupID = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 3:
            this.tipIme = ((System.Windows.Controls.TextBox)(target));
            
            #line 65 "..\..\Tip.xaml"
            this.tipIme.LostFocus += new System.Windows.RoutedEventHandler(this.tipIme_LostFocus);
            
            #line default
            #line hidden
            
            #line 65 "..\..\Tip.xaml"
            this.tipIme.GotFocus += new System.Windows.RoutedEventHandler(this.tipIme_GotFocus);
            
            #line default
            #line hidden
            
            #line 65 "..\..\Tip.xaml"
            this.tipIme.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.tipIme_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.popupIme = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 5:
            
            #line 81 "..\..\Tip.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 83 "..\..\Tip.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tipOpis = ((System.Windows.Controls.TextBox)(target));
            
            #line 84 "..\..\Tip.xaml"
            this.tipOpis.LostFocus += new System.Windows.RoutedEventHandler(this.tipOpis_LostFocus);
            
            #line default
            #line hidden
            
            #line 84 "..\..\Tip.xaml"
            this.tipOpis.GotFocus += new System.Windows.RoutedEventHandler(this.tipOpis_GotFocus);
            
            #line default
            #line hidden
            
            #line 84 "..\..\Tip.xaml"
            this.tipOpis.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.tipOpis_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 8:
            this.popupOpis = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 9:
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            
            #line 95 "..\..\Tip.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
