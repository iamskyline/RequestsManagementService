using System;
using System.Windows;
using System.Windows.Controls;
using RequestsManagementService.AppWindows.RequestWindows;
using RequestsManagementService.Models;

namespace RequestsManagementService.AppWindows.RolesWindows.ManagerWindows
{
    public partial class ManagerRequestsWindow : Window
    {
        public ManagerRequestsWindow()
        {
            InitializeComponent();
        }

        private void LogOutButton_OnClick(Object sender, RoutedEventArgs e)
        {
            //сбросить пользователя
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void SearchTextBox_OnTextChanged(Object sender, TextChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

       private void GetRequestDetailsButton_OnClick(Object sender, RoutedEventArgs e)
        {
            RequestInfoWindow window = new RequestInfoWindow((sender as Button).DataContext as Requests);
            window.ShowDialog();
        }

        private void OpenStatisticsButton_OnClick(Object sender, RoutedEventArgs e)
        {
            StatisticsWindow window = new StatisticsWindow();
            window.ShowDialog();
        }

        private void ChangeRequestDataButton_OnClick(Object sender, RoutedEventArgs e)
        {
            ManagerEditingRequestWindow window = new ManagerEditingRequestWindow();
            window.ShowDialog();
        }
    }
}
