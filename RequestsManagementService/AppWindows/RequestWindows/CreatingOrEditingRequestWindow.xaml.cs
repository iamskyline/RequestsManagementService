using System;
using System.Windows;
using System.Windows.Controls;

namespace RequestsManagementService.AppWindows.RequestWindows
{
    /// <summary>
    /// Логика взаимодействия для CreatingOrEditingRequestWindow.xaml
    /// </summary>
    public partial class CreatingOrEditingRequestWindow : Window
    {
        public CreatingOrEditingRequestWindow()
        {
            InitializeComponent();
        }

        private void GoBackButton_OnClick(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveRequestButton_OnClick(Object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void InputsScrollViewer_OnScrollChanged(Object sender, ScrollChangedEventArgs e)
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
                InputsScrollViewer.ScrollToVerticalOffset(e.VerticalOffset);
            }
        }
    }
}
