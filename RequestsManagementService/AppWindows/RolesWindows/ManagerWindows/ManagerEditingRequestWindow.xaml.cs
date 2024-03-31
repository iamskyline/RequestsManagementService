using System;
using System.Windows;

namespace RequestsManagementService.AppWindows.RolesWindows.ManagerWindows
{
    public partial class ManagerEditingRequestWindow : Window
    {
        public ManagerEditingRequestWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_OnClick(Object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GoBackButton_OnClick(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
