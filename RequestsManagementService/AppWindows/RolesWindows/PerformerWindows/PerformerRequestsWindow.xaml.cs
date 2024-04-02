using System;
using System.Collections.Generic;
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
            Requests selectedRequest = (sender as Button).DataContext as Requests;

            if (selectedRequest.StatusId != (Int32)RequestStatus.Finished && selectedRequest.StatusId != (Int32)RequestStatus.InExecution)
            {
                try
                {
                    MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите взять заявку в работу?",
                        "Взять заявку в работу", MessageBoxButton.YesNo,
                        MessageBoxImage.Warning);

                    if (result == MessageBoxResult.Yes)
                    {
                        using (RequestsManagementEntities context = new RequestsManagementEntities())
                        {
                            Requests request = context.Requests.Find(selectedRequest.Id);
                            request.StatusId = (Int32)RequestStatus.InExecution;

                            context.SaveChanges();

                            MessageBox.Show("Заявка взята в работу!",
                                "Успех!", MessageBoxButton.OK,
                                MessageBoxImage.Information);
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Ошибка! Вы не можете взять уже завершенную " +
                                "заявку или заявку, которая уже выполняется",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LogOutButton_OnClick(Object sender, RoutedEventArgs e)
        {
            Storage.SystemUser = null;
            MainWindow window = new MainWindow();
            window.Show();
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
    }
}
