using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using RequestsManagementService.AppWindows.RequestWindows;
using RequestsManagementService.Models;
using RequestsManagementService.Tools;

namespace RequestsManagementService.AppWindows.RolesWindows.ManagerWindows
{
    public partial class ManagerRequestsWindow : Window
    {
        private List<Requests> _allRequests;

        public ManagerRequestsWindow()
        {
            InitializeComponent();

            _allRequests = DbFunctions.GetAllRequests();
            RequestsItemsControl.ItemsSource = _allRequests;
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
            Searching.Search(_allRequests, SearchTextBox, RequestsItemsControl);
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
            ManagerEditingRequestWindow window = new ManagerEditingRequestWindow((sender as Button).DataContext as Requests);
            window.ShowDialog();
        }
    }
}
