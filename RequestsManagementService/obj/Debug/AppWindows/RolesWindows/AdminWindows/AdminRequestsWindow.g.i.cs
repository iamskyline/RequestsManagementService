﻿#pragma checksum "..\..\..\..\..\AppWindows\RolesWindows\AdminWindows\AdminRequestsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "32CE3B9B0EA2B0EE53DEF38E346A4E6390D96F42741D1505FEF97A984DF5E2E8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace RequestsManagementService.AppWindows.RolesWindows.AdminWindows {
    
    
    /// <summary>
    /// AdminRequestsWindow
    /// </summary>
    public partial class AdminRequestsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 31 "..\..\..\..\..\AppWindows\RolesWindows\AdminWindows\AdminRequestsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogOutButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\AppWindows\RolesWindows\AdminWindows\AdminRequestsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl itemsControl;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\..\..\AppWindows\RolesWindows\AdminWindows\AdminRequestsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\..\..\..\AppWindows\RolesWindows\AdminWindows\AdminRequestsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateRequestButton;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\..\..\AppWindows\RolesWindows\AdminWindows\AdminRequestsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenStatisticsButton;
        
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
            System.Uri resourceLocater = new System.Uri("/RequestsManagementService;component/appwindows/roleswindows/adminwindows/adminre" +
                    "questswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\AppWindows\RolesWindows\AdminWindows\AdminRequestsWindow.xaml"
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
            this.LogOutButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\..\AppWindows\RolesWindows\AdminWindows\AdminRequestsWindow.xaml"
            this.LogOutButton.Click += new System.Windows.RoutedEventHandler(this.LogOutButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.itemsControl = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 5:
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 151 "..\..\..\..\..\AppWindows\RolesWindows\AdminWindows\AdminRequestsWindow.xaml"
            this.SearchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTextBox_OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CreateRequestButton = ((System.Windows.Controls.Button)(target));
            
            #line 162 "..\..\..\..\..\AppWindows\RolesWindows\AdminWindows\AdminRequestsWindow.xaml"
            this.CreateRequestButton.Click += new System.Windows.RoutedEventHandler(this.CreateRequestButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.OpenStatisticsButton = ((System.Windows.Controls.Button)(target));
            
            #line 172 "..\..\..\..\..\AppWindows\RolesWindows\AdminWindows\AdminRequestsWindow.xaml"
            this.OpenStatisticsButton.Click += new System.Windows.RoutedEventHandler(this.OpenStatisticsButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 108 "..\..\..\..\..\AppWindows\RolesWindows\AdminWindows\AdminRequestsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GetRequestDetailsButton_OnClick);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 116 "..\..\..\..\..\AppWindows\RolesWindows\AdminWindows\AdminRequestsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditRequestButton_OnClick);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

