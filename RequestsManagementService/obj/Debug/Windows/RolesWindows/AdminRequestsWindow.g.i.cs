﻿#pragma checksum "..\..\..\..\Windows\RolesWindows\AdminRequestsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3BA56A851B8586907A119F98099D987425267B12E2DD3834F4B2BCC0C573FB94"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using RequestsManagementService.Windows;
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


namespace RequestsManagementService.Windows.RolesWindows {
    
    
    /// <summary>
    /// AdminRequestsWindow
    /// </summary>
    public partial class AdminRequestsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\Windows\RolesWindows\AdminRequestsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl itemsControl;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Windows\RolesWindows\AdminRequestsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GetRequestDetailsButton;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\Windows\RolesWindows\AdminRequestsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditRequestButton;
        
        #line default
        #line hidden
        
        
        #line 250 "..\..\..\..\Windows\RolesWindows\AdminRequestsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateRequestButton;
        
        #line default
        #line hidden
        
        
        #line 260 "..\..\..\..\Windows\RolesWindows\AdminRequestsWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/RequestsManagementService;component/windows/roleswindows/adminrequestswindow.xam" +
                    "l", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\RolesWindows\AdminRequestsWindow.xaml"
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
            
            #line 77 "..\..\..\..\Windows\RolesWindows\AdminRequestsWindow.xaml"
            this.GetRequestDetailsButton.Click += new System.Windows.RoutedEventHandler(this.GetRequestDetailsButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.EditRequestButton = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\..\Windows\RolesWindows\AdminRequestsWindow.xaml"
            this.EditRequestButton.Click += new System.Windows.RoutedEventHandler(this.EditRequestButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 150 "..\..\..\..\Windows\RolesWindows\AdminRequestsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GetRequestDetailsButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 158 "..\..\..\..\Windows\RolesWindows\AdminRequestsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditRequestButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 223 "..\..\..\..\Windows\RolesWindows\AdminRequestsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GetRequestDetailsButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 231 "..\..\..\..\Windows\RolesWindows\AdminRequestsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditRequestButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CreateRequestButton = ((System.Windows.Controls.Button)(target));
            
            #line 258 "..\..\..\..\Windows\RolesWindows\AdminRequestsWindow.xaml"
            this.CreateRequestButton.Click += new System.Windows.RoutedEventHandler(this.CreateRequestButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.LogOutButton = ((System.Windows.Controls.Button)(target));
            
            #line 268 "..\..\..\..\Windows\RolesWindows\AdminRequestsWindow.xaml"
            this.LogOutButton.Click += new System.Windows.RoutedEventHandler(this.LogOutButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

