using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using RequestsManagementService.AppWindows.RequestWindows;
using RequestsManagementService.Models;
using RequestsManagementService.Tools;

namespace RequestsManagementService.AppWindows.RolesWindows.PerformerWindows
{
    public partial class PerformerRequestsWindow : Window
    {
        private List<Requests> _allRequests;

        public PerformerRequestsWindow()
        {
            InitializeComponent();

            _allRequests = DbFunctions.GetAllRequests();
            RequestsItemsControl.ItemsSource = _allRequests;
        }

        private void GetRequestDetailsButton_OnClick(Object sender, RoutedEventArgs e)
        {
            RequestInfoWindow window = new RequestInfoWindow((sender as Button).DataContext as Requests);
            window.ShowDialog();
        }

        private void GetToWorkButton_OnClick(Object sender, RoutedEventArgs e)
        {
            PerformerExecuteRequestWindow window = new PerformerExecuteRequestWindow((sender as Button).DataContext as Requests);
            window.ShowDialog();

            RequestsItemsControl.ItemsSource = null;
            RequestsItemsControl.ItemsSource = DbFunctions.GetAllRequests();
        }

        private void LogOutButton_OnClick(Object sender, RoutedEventArgs e)
        {
            Storage.SystemUser = null;
            this.Close();
        }

        private void SearchTextBox_OnTextChanged(Object sender, TextChangedEventArgs e)
        {
            Searching.Search(_allRequests, SearchTextBox, RequestsItemsControl);
        }

        private void AddCommentButton_OnClick(Object sender, RoutedEventArgs e)
        {
            PerformerCommentWindow window = new PerformerCommentWindow((sender as Button).DataContext as Requests);
            window.ShowDialog();
        }

        private void PerformerRequestsWindow_OnClosing(Object sender, CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
