﻿#pragma checksum "..\..\Reset_main.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01F5EBD63588A321E9B75B725CFA46FB4829D6FA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Course_kepeer_1;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace Course_kepeer_1 {
    
    
    /// <summary>
    /// Reset_main
    /// </summary>
    public partial class Reset_main : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\Reset_main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.WatermarkTextBox log;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Reset_main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.WatermarkTextBox res;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\Reset_main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sav;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Reset_main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
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
            System.Uri resourceLocater = new System.Uri("/Course_kepeer_1;component/reset_main.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Reset_main.xaml"
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
            this.log = ((Xceed.Wpf.Toolkit.WatermarkTextBox)(target));
            
            #line 31 "..\..\Reset_main.xaml"
            this.log.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.res_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 31 "..\..\Reset_main.xaml"
            this.log.SelectionChanged += new System.Windows.RoutedEventHandler(this.res_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.res = ((Xceed.Wpf.Toolkit.WatermarkTextBox)(target));
            
            #line 40 "..\..\Reset_main.xaml"
            this.res.SelectionChanged += new System.Windows.RoutedEventHandler(this.res_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 40 "..\..\Reset_main.xaml"
            this.res.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.res_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.sav = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\Reset_main.xaml"
            this.sav.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\Reset_main.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

