﻿#pragma checksum "..\..\..\..\StockStuff\StockManipulation.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15EA7AEE70EE4A1B0EA60287C8B6407264A71891"
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
using WPF_App.StockStuff;


namespace WPF_App.StockStuff {
    
    
    /// <summary>
    /// StockManipulation
    /// </summary>
    public partial class StockManipulation : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\StockStuff\StockManipulation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock curentstocks;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\StockStuff\StockManipulation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox productComboBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\StockStuff\StockManipulation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox shopCombobox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF_App;component/stockstuff/stockmanipulation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\StockStuff\StockManipulation.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.curentstocks = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.productComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 30 "..\..\..\..\StockStuff\StockManipulation.xaml"
            this.productComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.productComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.shopCombobox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 31 "..\..\..\..\StockStuff\StockManipulation.xaml"
            this.shopCombobox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.shopCombobox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

