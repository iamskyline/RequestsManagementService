using RequestsManagementService.AppWindows.RolesWindows.PerformerWindows;
using System;
using System.Windows;
using RequestsManagementService.AppWindows.RolesWindows;
using RequestsManagementService.AppWindows.RolesWindows.AdminWindows;
using RequestsManagementService.AppWindows.RolesWindows.ManagerWindows;

namespace RequestsManagementService.AppWindows
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignInButton_OnClick(Object sender, RoutedEventArgs e)
        {
            AdminRequestsWindow window = new AdminRequestsWindow();
            //PerformerRequestsWindow window = new PerformerRequestsWindow();
            //ClientCreatingRequestWindow window = new ClientCreatingRequestWindow();
            //ManagerRequestsWindow window = new ManagerRequestsWindow();
            window.Show();
            this.Close();
        }
    }
}
