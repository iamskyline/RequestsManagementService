using System;
using System.Windows;
using System.Windows.Controls;
using RequestsManagementService.AppWindows.RequestWindows;
using RequestsManagementService.Models;
using RequestsManagementService.Tools;

namespace RequestsManagementService.AppWindows.RolesWindows.PerformerWindows
{
    public partial class PerformerRequestsWindow : Window
    {
        public PerformerRequestsWindow()
        {
            InitializeComponent();

            DbFunctions.LoadRequestsToItemsControl(RequestsItemsControl);
        }
        
        private void GetRequestDetailsButton_OnClick(Object sender, RoutedEventArgs e)
        {
            RequestInfoWindow window = new RequestInfoWindow((sender as Button).DataContext as Requests);
            window.ShowDialog();
        }

        private void GetToWorkButton_OnClick(Object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
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

        private void AddCommentButton_OnClick(Object sender, RoutedEventArgs e)
        {
            PerformerCommentWindow window = new PerformerCommentWindow();
            window.ShowDialog();
        }
    }
}
