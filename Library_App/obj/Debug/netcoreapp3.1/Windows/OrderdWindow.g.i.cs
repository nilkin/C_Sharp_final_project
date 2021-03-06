﻿#pragma checksum "..\..\..\..\Windows\OrderdWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1A34B5243B62F3F8A37179F2EC96A2B416D98906"
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
using Syncfusion;
using Syncfusion.Windows;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Converters;
using Xceed.Wpf.Toolkit.Core;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Mag.Converters;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace Library_App.Windows {
    
    
    /// <summary>
    /// OrderdWindow
    /// </summary>
    public partial class OrderdWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\Windows\OrderdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtCustomerId;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Windows\OrderdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtBookName;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Windows\OrderdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DtpCreatedAt;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Windows\OrderdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DtpDeadline;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Windows\OrderdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown myUpDownControl;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Windows\OrderdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblTotalprice;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Windows\OrderdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgOrder;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Windows\OrderdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn DgtId;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Windows\OrderdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn DgtBookName;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Windows\OrderdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn DgtCreatedAt;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Windows\OrderdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn DgtPassword;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Windows\OrderdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn DgtQuantity;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Windows\OrderdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn DgtTotalPrice;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Windows\OrderdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddOrder;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Windows\OrderdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSearchCustomer;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Windows\OrderdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSearchBook;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Windows\OrderdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDelete;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Windows\OrderdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMain;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\Windows\OrderdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblResultCustomerName;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Windows\OrderdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblResultBookName;
        
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
            System.Uri resourceLocater = new System.Uri("/Library_App;V1.0.0.0;component/windows/orderdwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\OrderdWindow.xaml"
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
            this.TxtCustomerId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TxtBookName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DtpCreatedAt = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.DtpDeadline = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.myUpDownControl = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            
            #line 37 "..\..\..\..\Windows\OrderdWindow.xaml"
            this.myUpDownControl.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.myUpDownControl_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LblTotalprice = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.DgOrder = ((System.Windows.Controls.DataGrid)(target));
            
            #line 41 "..\..\..\..\Windows\OrderdWindow.xaml"
            this.DgOrder.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DgOrder_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DgtId = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 9:
            this.DgtBookName = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 10:
            this.DgtCreatedAt = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 11:
            this.DgtPassword = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 12:
            this.DgtQuantity = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 13:
            this.DgtTotalPrice = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 14:
            this.BtnAddOrder = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\Windows\OrderdWindow.xaml"
            this.BtnAddOrder.Click += new System.Windows.RoutedEventHandler(this.BtnAddOrder_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.BtnSearchCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\Windows\OrderdWindow.xaml"
            this.BtnSearchCustomer.Click += new System.Windows.RoutedEventHandler(this.BtnSearchCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.BtnSearchBook = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\Windows\OrderdWindow.xaml"
            this.BtnSearchBook.Click += new System.Windows.RoutedEventHandler(this.BtnSearchBook_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.BtnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\..\Windows\OrderdWindow.xaml"
            this.BtnDelete.Click += new System.Windows.RoutedEventHandler(this.BtnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.BtnMain = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\Windows\OrderdWindow.xaml"
            this.BtnMain.Click += new System.Windows.RoutedEventHandler(this.BtnMain_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.LblResultCustomerName = ((System.Windows.Controls.Label)(target));
            return;
            case 20:
            this.LblResultBookName = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

