﻿#pragma checksum "..\..\MapFireAnalysisView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A4B7C83721DFB205FBC20C0BDFC8F931C6BA71A2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Genetec.Sdk.Controls;
using Genetec.Sdk.Controls.Maps;
using Genetec.Sdk.Controls.Themes.Styles;
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


namespace MapInteractionSample {
    
    
    /// <summary>
    /// MapFireAnalysisView
    /// </summary>
    public partial class MapFireAnalysisView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\MapFireAnalysisView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MapInteractionSample.MapFireAnalysisView ctl;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MapFireAnalysisView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox m_comboMaps;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\MapFireAnalysisView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Genetec.Sdk.Controls.Maps.MapControl m_mapControl;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\MapFireAnalysisView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox m_filtersList;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\MapFireAnalysisView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox m_countsList;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\MapFireAnalysisView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox m_fireList;
        
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
            System.Uri resourceLocater = new System.Uri("/MapInteractionSample;component/mapfireanalysisview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MapFireAnalysisView.xaml"
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
            this.ctl = ((MapInteractionSample.MapFireAnalysisView)(target));
            return;
            case 2:
            this.m_comboMaps = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\MapFireAnalysisView.xaml"
            this.m_comboMaps.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnComboMapsSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.m_mapControl = ((Genetec.Sdk.Controls.Maps.MapControl)(target));
            return;
            case 4:
            this.m_filtersList = ((System.Windows.Controls.ListBox)(target));
            
            #line 71 "..\..\MapFireAnalysisView.xaml"
            this.m_filtersList.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.OnFireListMouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 74 "..\..\MapFireAnalysisView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OnFireListboxContextMenuClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.m_countsList = ((System.Windows.Controls.ListBox)(target));
            
            #line 90 "..\..\MapFireAnalysisView.xaml"
            this.m_countsList.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.OnFireListMouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 93 "..\..\MapFireAnalysisView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OnFireListboxContextMenuClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.m_fireList = ((System.Windows.Controls.ListBox)(target));
            
            #line 123 "..\..\MapFireAnalysisView.xaml"
            this.m_fireList.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.OnFireListMouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 126 "..\..\MapFireAnalysisView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OnFireListboxContextMenuClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

