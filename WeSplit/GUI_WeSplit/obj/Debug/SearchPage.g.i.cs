﻿#pragma checksum "..\..\SearchPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "179D49B4F74056707B548E8F4685EEB700753B8E98C22B4768C430994A821BAA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GUI_WeSplit;
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


namespace GUI_WeSplit {
    
    
    /// <summary>
    /// SearchPage
    /// </summary>
    public partial class SearchPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\SearchPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBar;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\SearchPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ResultListView;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\SearchPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridView myGridView;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\SearchPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radionBtn_SearchTrip;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\SearchPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioBtn_SearchMember;
        
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
            System.Uri resourceLocater = new System.Uri("/GUI_WeSplit;component/searchpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SearchPage.xaml"
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
            this.SearchBar = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\SearchPage.xaml"
            this.SearchBar.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchBar_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ResultListView = ((System.Windows.Controls.ListView)(target));
            
            #line 35 "..\..\SearchPage.xaml"
            this.ResultListView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ResultListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.myGridView = ((System.Windows.Controls.GridView)(target));
            return;
            case 4:
            this.radionBtn_SearchTrip = ((System.Windows.Controls.RadioButton)(target));
            
            #line 72 "..\..\SearchPage.xaml"
            this.radionBtn_SearchTrip.Checked += new System.Windows.RoutedEventHandler(this.radionBtn_SearchTrip_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.radioBtn_SearchMember = ((System.Windows.Controls.RadioButton)(target));
            
            #line 78 "..\..\SearchPage.xaml"
            this.radioBtn_SearchMember.Checked += new System.Windows.RoutedEventHandler(this.radioBtn_SearchMember_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
