﻿#pragma checksum "..\..\QuanLyThueNha.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "93D97325ED2ADBB5906B9B8AC18484525FD243FFBC169C5B77C34C64C9B2DA41"
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
using WPF_ADO;


namespace WPF_ADO {
    
    
    /// <summary>
    /// QuanLyThueNha
    /// </summary>
    public partial class QuanLyThueNha : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\QuanLyThueNha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMaNha;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\QuanLyThueNha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTenChuNha;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\QuanLyThueNha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGiaThue;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\QuanLyThueNha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdYes;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\QuanLyThueNha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdNo;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\QuanLyThueNha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\QuanLyThueNha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnThem;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\QuanLyThueNha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSua;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\QuanLyThueNha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnXoa;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\QuanLyThueNha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLamMoi;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_ADO;component/quanlythuenha.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\QuanLyThueNha.xaml"
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
            this.txtMaNha = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtTenChuNha = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtGiaThue = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.rdYes = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.rdNo = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.DataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 47 "..\..\QuanLyThueNha.xaml"
            this.DataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnThem = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\QuanLyThueNha.xaml"
            this.btnThem.Click += new System.Windows.RoutedEventHandler(this.btnThem_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnSua = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\QuanLyThueNha.xaml"
            this.btnSua.Click += new System.Windows.RoutedEventHandler(this.btnSua_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnXoa = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\QuanLyThueNha.xaml"
            this.btnXoa.Click += new System.Windows.RoutedEventHandler(this.btnXoa_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnLamMoi = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

