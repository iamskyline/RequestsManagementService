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

            TotalRequestQuantity.Text = DbStatisticsCalculations.CountAllRequests().ToString();
            FinishedRequestsQuantity.Text = DbStatisticsCalculations.CountFinishedRequests().ToString();
            RequestsInProcessingQuantity.Text = DbStatisticsCalculations.CountRequestsInProcessing().ToString();
            RequestsInExecutionProcessQuantity.Text = DbStatisticsCalculations.CountRequestsInExecutionProcess().ToString();
            RequestsInPartiallyCompletedQuantity.Text = DbStatisticsCalculations.CountRequestsInPartiallyCompleted().ToString();
        }

        private void GoBackButton_OnClick(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
