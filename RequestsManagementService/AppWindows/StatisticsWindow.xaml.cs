using RequestsManagementService.Tools;
using System;
using System.Windows;

namespace RequestsManagementService.AppWindows
{
    public partial class StatisticsWindow : Window
    {
        public StatisticsWindow()
        {
            InitializeComponent();

            TotalRequestQuantity.Text = DbFunctions.CountAllRequests().ToString();
            FinishedRequestsQuantity.Text = DbFunctions.CountFinishedRequests().ToString();
            RequestsInProcessingQuantity.Text = DbFunctions.CountRequestsInProcessing().ToString();
            RequestsInExecutionProcessQuantity.Text = DbFunctions.CountRequestsInExecutionProcess().ToString();
            RequestsInPartiallyCompletedQuantity.Text = DbFunctions.CountRequestsInPartiallyCompleted().ToString();
        }

        private void GoBackButton_OnClick(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
