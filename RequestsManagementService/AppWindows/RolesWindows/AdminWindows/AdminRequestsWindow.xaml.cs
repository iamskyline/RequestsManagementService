using RequestsManagementService.AppWindows.RequestWindows;
using RequestsManagementService.Tools;
using System;
using System.Windows;
using System.Windows.Controls;
using RequestsManagementService.Models;

namespace RequestsManagementService.AppWindows.RolesWindows.AdminWindows
{
    public partial class AdminRequestsWindow : Window
    {
        public AdminRequestsWindow()
        {
            InitializeComponent();
            DbFunctions.LoadRequestsToItemsControl(RequestItemsControl);
        }

        private void EditRequestButton_OnClick(Object sender, RoutedEventArgs e)
        {
            EditingRequestWindow window = new EditingRequestWindow((sender as Button).DataContext as Requests);
            window.ShowDialog();
        }

        private void GetRequestDetailsButton_OnClick(Object sender, RoutedEventArgs e)
        {
            RequestInfoWindow window = new RequestInfoWindow((sender as Button).DataContext as Requests);
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
            CreatingRequestWindow window = new CreatingRequestWindow();
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
