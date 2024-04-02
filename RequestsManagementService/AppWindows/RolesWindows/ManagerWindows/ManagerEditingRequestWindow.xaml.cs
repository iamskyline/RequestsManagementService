using RequestsManagementService.Models;
using RequestsManagementService.Tools;
using System;
using System.Windows;

namespace RequestsManagementService.AppWindows.RolesWindows.ManagerWindows
{
    public partial class ManagerEditingRequestWindow : Window
    {
        private Requests _request;

        public ManagerEditingRequestWindow(Requests request)
        {
            _request = request;
            DataContext = _request;
            InitializeComponent();

            ComboBoxesFilling.FillPerformersToComboBox(PerformerComboBox);
        }

        private void SaveButton_OnClick(Object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GoBackButton_OnClick(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
