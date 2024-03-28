using System;
using System.Windows;

namespace RequestsManagementService.Windows.RolesWindows
{
    /// <summary>
    /// Логика взаимодействия для AdminRequestsWindow.xaml
    /// </summary>
    public partial class AdminRequestsWindow : Window
    {
        public AdminRequestsWindow()
        {
            InitializeComponent();
        }

        private void EditRequestButton_OnClick(Object sender, RoutedEventArgs e)
        {
            CreatingOrEditingRequestWindow window = new CreatingOrEditingRequestWindow();
            window.ShowDialog();
        }

        private void GetRequestDetailsButton_OnClick(Object sender, RoutedEventArgs e)
        {
            RequestInfoWindow window = new RequestInfoWindow();
            window.ShowDialog();
        }

        private void LogOutButton_OnClick(Object sender, RoutedEventArgs e)
        {
            //сбросить пользователя
            this.Close();
        }
    }
}
