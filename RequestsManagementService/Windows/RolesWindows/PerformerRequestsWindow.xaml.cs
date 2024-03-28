using System;
using System.Windows;

namespace RequestsManagementService.Windows.RolesWindows
{
    /// <summary>
    /// Логика взаимодействия для PerformerRequestsWindow.xaml
    /// </summary>
    public partial class PerformerRequestsWindow : Window
    {
        public PerformerRequestsWindow()
        {
            InitializeComponent();
        }
        
        private void GetRequestDetailsButton_OnClick(Object sender, RoutedEventArgs e)
        {
            RequestInfoWindow window = new RequestInfoWindow();
            window.ShowDialog();
        }

        private void GetToWorkButton_OnClick(Object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LogOutButton_OnClick(Object sender, RoutedEventArgs e)
        {
            //сбросить пользователя
            this.Close();
        }
    }
}
