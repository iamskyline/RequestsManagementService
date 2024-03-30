using System;
using System.Windows;

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
    }
}
