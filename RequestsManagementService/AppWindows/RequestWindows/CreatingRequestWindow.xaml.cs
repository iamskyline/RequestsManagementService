using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using RequestsManagementService.Models;
using RequestsManagementService.Tools;
using Validation = RequestsManagementService.Tools.Validation;

namespace RequestsManagementService.AppWindows.RequestWindows
{
    public partial class CreatingRequestWindow : Window
    {
        public CreatingRequestWindow()
        {
            InitializeComponent();
            ComboBoxesFilling.FillClientsToComboBoxes(ClientComboBox);
            ComboBoxesFilling.FillStatusesToComboBox(StatusComboBox);
            SetDefaultDataToDatePicker();
        }

        private void SetDefaultDataToDatePicker()
        {
            NewDayDatePicker.SelectedDate = DateTime.Now.AddDays(3);

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
            StringBuilder errors = Validation.ValidateAdminBlank(ClientComboBox, StatusComboBox, EquipmentTextBox,
                MalfunctionTextBox, NewTimeTextBox, NewDayDatePicker);

            if (errors.Length == 0)
            {
                try
                {
                    using (RequestsManagementEntities context = new RequestsManagementEntities())
                    {
                        Users findedClient = DbFunctions.GetUserByLogin(ClientComboBox.Text);
                        Statuses findedStatus = DbFunctions.GetStatusByName(StatusComboBox.Text);

                        Requests newRequest = new Requests()
                        {
                            UserId = findedClient.Id,
                            StatusId = findedStatus.Id,
                            CreatedDate = DateTime.Now,
                            Equipment = EquipmentTextBox.Text,
                            Malfunction = MalfunctionTextBox.Text,
                            IssueDescription = IssueDescriptionTextBox.Text,
                            ExpectedCompletionDate = NewDayDatePicker.SelectedDate != null 
                                ? DateTime.Parse(NewDayDatePicker.SelectedDate.ToString()) 
                                : DateTime.Now.AddDays(3),
                            ExpectedCompletionTime = TimeSpan.Parse(NewTimeTextBox.Text)
                        };

                        context.Requests.Add(newRequest);
                        context.SaveChanges();
                        MessageBox.Show("Заявка успешно создана!", "Успех!", MessageBoxButton.OK,
                            MessageBoxImage.Information);
                        this.Close();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else 
                MessageBox.Show($"При заполнении формы заявки " +
                                $"произошли следующие проблемы:\n\n{errors}", "Внимание!",
                                MessageBoxButton.OK, MessageBoxImage.Error
            );
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
