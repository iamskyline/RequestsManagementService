using System;
using System.Windows;
using RequestsManagementService.Windows.RolesWindows;

namespace RequestsManagementService.Windows
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
            window.Show();
            this.Close();
        }
    }
}
