using System;
using System.Windows;
using System.Windows.Controls;
using RequestsManagementService.Models;

namespace RequestsManagementService.AppWindows.RequestWindows
{
    public partial class RequestInfoWindow : Window
    {
        private Requests _request;

        public RequestInfoWindow(Requests request)
        {
            _request = request;
            DataContext = _request;
            InitializeComponent();
        }

        private void GoBackButton_OnClick(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DataScrollViewer_OnScrollChanged(Object sender, ScrollChangedEventArgs e)
        {
            if (e.VerticalChange != 0)
            {
                TitlesScrollViewer.ScrollToVerticalOffset(e.VerticalOffset);
            }
        }

        private void TitlesScrollViewer_OnScrollChanged(Object sender, ScrollChangedEventArgs e)
        {
            if (e.VerticalChange != 0)
            {
                DataScrollViewer.ScrollToVerticalOffset(e.VerticalOffset);
            }
        }
    }
}
