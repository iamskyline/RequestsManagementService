using System;
using System.Windows;
using System.Windows.Controls;
using RequestsManagementService.AppWindows.RequestWindows;

namespace RequestsManagementService.AppWindows.RolesWindows.AdminWindows
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
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void CreateRequestButton_OnClick(Object sender, RoutedEventArgs e)
        {
            CreatingOrEditingRequestWindow window = new CreatingOrEditingRequestWindow();
            window.ShowDialog();
        }

        private void SearchTextBox_OnTextChanged(Object sender, TextChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OpenStatisticsButton_OnClick(Object sender, RoutedEventArgs e)
        {
            StatisticsWindow window = new StatisticsWindow();
            window.ShowDialog();
        }
    }
}
