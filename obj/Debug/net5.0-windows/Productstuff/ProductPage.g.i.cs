﻿#pragma checksum "..\..\..\..\Productstuff\ProductPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60F9B745FDE8E1A34E42298C4C829719D50EC268"
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
using WPF_App;


namespace WPF_App {
    
    
    /// <summary>
    /// ProductPage
    /// </summary>
    public partial class ProductPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\Productstuff\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addItem;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Productstuff\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteItem;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Productstuff\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showItems;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Productstuff\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editItem;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Productstuff\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchitem;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Productstuff\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idToSearch;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Productstuff\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SearchedItem;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_App;V1.0.0.0;component/productstuff/productpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Productstuff\ProductPage.xaml"
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
            this.addItem = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\Productstuff\ProductPage.xaml"
            this.addItem.Click += new System.Windows.RoutedEventHandler(this.addItem_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.deleteItem = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\Productstuff\ProductPage.xaml"
            this.deleteItem.Click += new System.Windows.RoutedEventHandler(this.deleteItem_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.showItems = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\Productstuff\ProductPage.xaml"
            this.showItems.Click += new System.Windows.RoutedEventHandler(this.showItems_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.editItem = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\Productstuff\ProductPage.xaml"
            this.editItem.Click += new System.Windows.RoutedEventHandler(this.editItem_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.searchitem = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\Productstuff\ProductPage.xaml"
            this.searchitem.Click += new System.Windows.RoutedEventHandler(this.searchitem_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.idToSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.SearchedItem = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

