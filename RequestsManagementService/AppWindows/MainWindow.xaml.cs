using RequestsManagementService.AppWindows.RolesWindows.AdminWindows;
using System;
using System.Windows;

namespace RequestsManagementService.AppWindows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
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
            window.Show();
            this.Close();
        }
    }
}
