using System;
using System.Windows;
using System.Windows.Controls;
using RequestsManagementService.Tools;

namespace RequestsManagementService.AppWindows.RequestWindows
{
    public partial class CreatingRequestWindow : Window
    {
        public CreatingRequestWindow()
        {
            InitializeComponent();
            DbFunctions.LoadDataToComboBoxes(ClientComboBox, StatusComboBox);
            SetDefaultDataToDatePicker();
        }

        private void SetDefaultDataToDatePicker()
        {
            NewDayDatePicker.SelectedDate = DateTime.Now;

            String hours = DateTime.Now.Hour.ToString();
            String minutes = DateTime.Now.Minute.ToString();
            String seconds = DateTime.Now.Second.ToString();
            NewTimeTextBox.Text = $"{hours}:{minutes}:{seconds}";
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
