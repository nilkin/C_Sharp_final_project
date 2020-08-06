﻿#pragma checksum "..\..\..\..\Windows\ManagementWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "100DA79D695D8AA76BAD323384F3A57686DEE13F"
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
    /// ManagementWindow
    /// </summary>
    public partial class ManagementWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\..\Windows\ManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblName;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Windows\ManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtName;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Windows\ManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblSurname;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Windows\ManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtSurname;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Windows\ManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblUsername;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Windows\ManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtUsername;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Windows\ManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblPassword;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Windows\ManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtPassword;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Windows\ManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbxPosition;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Windows\ManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAdd;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Windows\ManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDelete;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Windows\ManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUpdate;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Windows\ManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRead;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Windows\ManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgPerson;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Windows\ManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn DgtName;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Windows\ManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn DgtSurname;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Windows\ManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn DgtUsername;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Windows\ManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn DgtPassword;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Windows\ManagementWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Library_App;component/windows/managementwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\ManagementWindow.xaml"
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
            this.LblSurname = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.TxtSurname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.LblUsername = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.TxtUsername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.LblPassword = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.TxtPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.CbxPosition = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.BtnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\Windows\ManagementWindow.xaml"
            this.BtnAdd.Click += new System.Windows.RoutedEventHandler(this.BtnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.BtnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\Windows\ManagementWindow.xaml"
            this.BtnDelete.Click += new System.Windows.RoutedEventHandler(this.BtnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.BtnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\Windows\ManagementWindow.xaml"
            this.BtnUpdate.Click += new System.Windows.RoutedEventHandler(this.BtnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.BtnRead = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\..\Windows\ManagementWindow.xaml"
            this.BtnRead.Click += new System.Windows.RoutedEventHandler(this.BtnRead_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.DgPerson = ((System.Windows.Controls.DataGrid)(target));
            
            #line 55 "..\..\..\..\Windows\ManagementWindow.xaml"
            this.DgPerson.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DgPerson_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 15:
            this.DgtName = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 16:
            this.DgtSurname = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 17:
            this.DgtUsername = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 18:
            this.DgtPassword = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 19:
            this.DgtPosition = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

