﻿#pragma checksum "..\..\..\..\UserControler\SetachWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25B4630F0EFC6C535C1D1C2C5440830BC59A1F94"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Sihor.UserControler;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Sihor.UserControler {
    
    
    /// <summary>
    /// SetachWindow
    /// </summary>
    public partial class SetachWindow : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\UserControler\SetachWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbShitot;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\UserControler\SetachWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCustomValue;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\UserControler\SetachWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtnote;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\UserControler\SetachWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtseaarch;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\UserControler\SetachWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\UserControler\SetachWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listshior;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\..\UserControler\SetachWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btncal;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Sihor;component/usercontroler/setachwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControler\SetachWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.cmbShitot = ((System.Windows.Controls.ComboBox)(target));
            
            #line 32 "..\..\..\..\UserControler\SetachWindow.xaml"
            this.cmbShitot.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbShitot_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtCustomValue = ((System.Windows.Controls.TextBox)(target));
            
            #line 52 "..\..\..\..\UserControler\SetachWindow.xaml"
            this.txtCustomValue.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtCustomValue_KeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtnote = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.txtseaarch = ((System.Windows.Controls.TextBox)(target));
            
            #line 78 "..\..\..\..\UserControler\SetachWindow.xaml"
            this.txtseaarch.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtseaarch_KeyUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.listshior = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            this.btncal = ((System.Windows.Controls.Button)(target));
            
            #line 164 "..\..\..\..\UserControler\SetachWindow.xaml"
            this.btncal.Click += new System.Windows.RoutedEventHandler(this.btncal_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

