﻿#pragma checksum "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerRequestsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9B405E917D486D08EACBD69235D19CFE5D15D525076E6A0FBA4D2DA934178FF9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using RequestsManagementService.AppWindows.RolesWindows.ManagerWindows;
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


namespace RequestsManagementService.AppWindows.RolesWindows.ManagerWindows {
    
    
    /// <summary>
    /// ManagerRequestsWindow
    /// </summary>
    public partial class ManagerRequestsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerRequestsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl itemsControl;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerRequestsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GetRequestDetailsButton;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerRequestsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeRequestDataButton;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerRequestsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerRequestsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenStatisticsButton;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerRequestsWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/RequestsManagementService;component/appwindows/roleswindows/managerwindows/manag" +
                    "errequestswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerRequestsWindow.xaml"
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
            
            #line 92 "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerRequestsWindow.xaml"
            this.GetRequestDetailsButton.Click += new System.Windows.RoutedEventHandler(this.GetRequestDetailsButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ChangeRequestDataButton = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerRequestsWindow.xaml"
            this.ChangeRequestDataButton.Click += new System.Windows.RoutedEventHandler(this.ChangeRequestDataButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 138 "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerRequestsWindow.xaml"
            this.SearchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTextBox_OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.OpenStatisticsButton = ((System.Windows.Controls.Button)(target));
            
            #line 150 "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerRequestsWindow.xaml"
            this.OpenStatisticsButton.Click += new System.Windows.RoutedEventHandler(this.OpenStatisticsButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LogOutButton = ((System.Windows.Controls.Button)(target));
            
            #line 161 "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerRequestsWindow.xaml"
            this.LogOutButton.Click += new System.Windows.RoutedEventHandler(this.LogOutButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

