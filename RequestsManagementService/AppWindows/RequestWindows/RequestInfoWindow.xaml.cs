using System;
using System.Windows;
using System.Windows.Controls;

namespace RequestsManagementService.AppWindows.RequestWindows
{
    /// <summary>
    /// Логика взаимодействия для RequestInfoWindow.xaml
    /// </summary>
    public partial class RequestInfoWindow : Window
    {
        public RequestInfoWindow()
        {
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
