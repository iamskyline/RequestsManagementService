﻿#pragma checksum "..\..\..\..\AppWindows\RolesWindows\PerformerRequestsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "81A096E46F077D08CBD8B5AA8735A386B2DFD286B60F352818644B7B3E4C18B0"
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


namespace RequestsManagementService.AppWindows.RolesWindows {
    
    
    /// <summary>
    /// PerformerRequestsWindow
    /// </summary>
    public partial class PerformerRequestsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\AppWindows\RolesWindows\PerformerRequestsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl itemsControl;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\AppWindows\RolesWindows\PerformerRequestsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GetRequestDetailsButton;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\AppWindows\RolesWindows\PerformerRequestsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GetToWorkButton;
        
        #line default
        #line hidden
        
        
        #line 241 "..\..\..\..\AppWindows\RolesWindows\PerformerRequestsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogOutButton;
        
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
            System.Uri resourceLocater = new System.Uri("/RequestsManagementService;component/appwindows/roleswindows/performerrequestswin" +
                    "dow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\AppWindows\RolesWindows\PerformerRequestsWindow.xaml"
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
            this.itemsControl = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 2:
            this.GetRequestDetailsButton = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\AppWindows\RolesWindows\PerformerRequestsWindow.xaml"
            this.GetRequestDetailsButton.Click += new System.Windows.RoutedEventHandler(this.GetRequestDetailsButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GetToWorkButton = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\..\AppWindows\RolesWindows\PerformerRequestsWindow.xaml"
            this.GetToWorkButton.Click += new System.Windows.RoutedEventHandler(this.GetToWorkButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 149 "..\..\..\..\AppWindows\RolesWindows\PerformerRequestsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GetRequestDetailsButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 157 "..\..\..\..\AppWindows\RolesWindows\PerformerRequestsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GetToWorkButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 222 "..\..\..\..\AppWindows\RolesWindows\PerformerRequestsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GetRequestDetailsButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 230 "..\..\..\..\AppWindows\RolesWindows\PerformerRequestsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GetToWorkButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.LogOutButton = ((System.Windows.Controls.Button)(target));
            
            #line 248 "..\..\..\..\AppWindows\RolesWindows\PerformerRequestsWindow.xaml"
            this.LogOutButton.Click += new System.Windows.RoutedEventHandler(this.LogOutButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
