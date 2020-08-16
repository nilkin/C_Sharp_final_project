﻿#pragma checksum "..\..\..\..\Windows\BookWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14599C37415F2F4AE866E76CEB354B7ADB18A302"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Library_App.Models;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Library_App.Windows {
    
    
    /// <summary>
    /// BookWindow
    /// </summary>
    public partial class BookWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\..\Windows\BookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblName;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Windows\BookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtName;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Windows\BookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblPrice;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Windows\BookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtPrice;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Windows\BookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblPages;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Windows\BookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtPages;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Windows\BookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblQuantity;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Windows\BookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtQuantity;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Windows\BookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblLanguage;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Windows\BookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbxLanguage;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Windows\BookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAdd;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Windows\BookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDelete;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Windows\BookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUpdate;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Windows\BookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRead;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Windows\BookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMain;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Windows\BookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgPerson;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Windows\BookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn DgtName;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Windows\BookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn DgtSurname;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Windows\BookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn DgtUsername;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Windows\BookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn DgtPassword;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Windows\BookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn DgtPosition;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Library_App;component/windows/bookwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\BookWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LblName = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.TxtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.LblPrice = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.TxtPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.LblPages = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.TxtPages = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.LblQuantity = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.TxtQuantity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.LblLanguage = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.CbxLanguage = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.BtnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\Windows\BookWindow.xaml"
            this.BtnAdd.Click += new System.Windows.RoutedEventHandler(this.BtnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.BtnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\Windows\BookWindow.xaml"
            this.BtnDelete.Click += new System.Windows.RoutedEventHandler(this.BtnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.BtnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\Windows\BookWindow.xaml"
            this.BtnUpdate.Click += new System.Windows.RoutedEventHandler(this.BtnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.BtnRead = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\..\Windows\BookWindow.xaml"
            this.BtnRead.Click += new System.Windows.RoutedEventHandler(this.BtnRead_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.BtnMain = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\Windows\BookWindow.xaml"
            this.BtnMain.Click += new System.Windows.RoutedEventHandler(this.BtnMain_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.DgPerson = ((System.Windows.Controls.DataGrid)(target));
            
            #line 57 "..\..\..\..\Windows\BookWindow.xaml"
            this.DgPerson.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DgPerson_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 17:
            this.DgtName = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 18:
            this.DgtSurname = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 19:
            this.DgtUsername = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 20:
            this.DgtPassword = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 21:
            this.DgtPosition = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

