﻿#pragma checksum "..\..\..\..\Productstuff\EditItemWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F6B7D0EF79C873F87867BCA33340E7CB41BAF0AD"
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
using WPF_App.Productstuff;


namespace WPF_App.Productstuff {
    
    
    /// <summary>
    /// EditItemWindow
    /// </summary>
    public partial class EditItemWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\Productstuff\EditItemWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idToEdit;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Productstuff\EditItemWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox productNameEdit;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Productstuff\EditItemWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox productPriceEdit;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Productstuff\EditItemWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox productTypeEdit;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Productstuff\EditItemWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchItem;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Productstuff\EditItemWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button applyChanges;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_App;V1.0.0.0;component/productstuff/edititemwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Productstuff\EditItemWindow.xaml"
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
            this.idToEdit = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.productNameEdit = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.productPriceEdit = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.productTypeEdit = ((System.Windows.Controls.ComboBox)(target));
            
            #line 30 "..\..\..\..\Productstuff\EditItemWindow.xaml"
            this.productTypeEdit.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.productTypeEdit_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.searchItem = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\Productstuff\EditItemWindow.xaml"
            this.searchItem.Click += new System.Windows.RoutedEventHandler(this.searchItem_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.applyChanges = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\Productstuff\EditItemWindow.xaml"
            this.applyChanges.Click += new System.Windows.RoutedEventHandler(this.applyChanges_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

