﻿#pragma checksum "..\..\..\..\AppWindows\RolesWindows\ClientCreatingRequestWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A0C109FEC8BA56C470525F99BCCBE0A91E1DBCC08892AC3EE31FDAFCC3245A1B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using RequestsManagementService.AppWindows.RolesWindows;
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
    /// ClientCreatingRequestWindow
    /// </summary>
    public partial class ClientCreatingRequestWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 67 "..\..\..\..\AppWindows\RolesWindows\ClientCreatingRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EquipmentTextBox;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\AppWindows\RolesWindows\ClientCreatingRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MalfunctionTextBox;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\AppWindows\RolesWindows\ClientCreatingRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IssueDescriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\AppWindows\RolesWindows\ClientCreatingRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateRequestButton;
        
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
            System.Uri resourceLocater = new System.Uri("/RequestsManagementService;component/appwindows/roleswindows/clientcreatingreques" +
                    "twindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\AppWindows\RolesWindows\ClientCreatingRequestWindow.xaml"
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
            this.EquipmentTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.MalfunctionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.IssueDescriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CreateRequestButton = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\..\AppWindows\RolesWindows\ClientCreatingRequestWindow.xaml"
            this.CreateRequestButton.Click += new System.Windows.RoutedEventHandler(this.CreateRequestButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
