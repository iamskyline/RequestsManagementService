﻿#pragma checksum "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerEditingRequestWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4D94B9EECF839C6E0039DC8209B68B550FC86AA30C3C56DEDFF654864C498CCA"
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
    /// ManagerEditingRequestWindow
    /// </summary>
    public partial class ManagerEditingRequestWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 66 "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerEditingRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker NewDayDatePicker;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerEditingRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewTimeTextBox;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerEditingRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PerformerComboBox;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerEditingRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButton;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerEditingRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoBackButton;
        
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
                    "ereditingrequestwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerEditingRequestWindow.xaml"
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
            this.NewDayDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 2:
            this.NewTimeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.PerformerComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.SaveButton = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerEditingRequestWindow.xaml"
            this.SaveButton.Click += new System.Windows.RoutedEventHandler(this.SaveButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GoBackButton = ((System.Windows.Controls.Button)(target));
            
            #line 108 "..\..\..\..\..\AppWindows\RolesWindows\ManagerWindows\ManagerEditingRequestWindow.xaml"
            this.GoBackButton.Click += new System.Windows.RoutedEventHandler(this.GoBackButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

