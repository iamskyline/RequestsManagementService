using RequestsManagementService.AppWindows.RequestWindows;
using RequestsManagementService.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using RequestsManagementService.Models;

namespace RequestsManagementService.AppWindows.RolesWindows.AdminWindows
{
    public partial class AdminRequestsWindow : Window
    {
        private List<Requests> _allRequests;

        public AdminRequestsWindow()
        {
            InitializeComponent();
            _allRequests = DbFunctions.GetAllRequests();
            RequestsItemsControl.ItemsSource = _allRequests;
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
            Storage.SystemUser = null;
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void CreateRequestButton_OnClick(Object sender, RoutedEventArgs e)
        {
            CreatingRequestWindow window = new CreatingRequestWindow();
            window.ShowDialog();

            RequestsItemsControl.ItemsSource = null;
            RequestsItemsControl.ItemsSource = DbFunctions.GetAllRequests();
        }

        private void SearchTextBox_OnTextChanged(Object sender, TextChangedEventArgs e)
        {
            Searching.Search(_allRequests, SearchTextBox, RequestsItemsControl);
        }

        private void OpenStatisticsButton_OnClick(Object sender, RoutedEventArgs e)
        {
            StatisticsWindow window = new StatisticsWindow();
            window.ShowDialog();
        }
    }
}
