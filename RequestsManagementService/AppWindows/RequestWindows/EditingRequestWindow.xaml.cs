using System;
using RequestsManagementService.Models;
using System.Windows;
using System.Windows.Controls;
using RequestsManagementService.Tools;
using System.Linq;
using System.Text;
using Validation = RequestsManagementService.Tools.Validation;

namespace RequestsManagementService.AppWindows.RequestWindows
{
    public partial class EditingRequestWindow : Window
    {
        private Requests _request;

        public EditingRequestWindow(Requests request)
        {
            _request = request;
            DataContext = _request;
            InitializeComponent();

            ComboBoxesFilling.FillClientsToComboBoxes(ClientComboBox, _request);
            ComboBoxesFilling.FillStatusesToComboBox(StatusComboBox);
        }

        private void TitlesScrollViewer_OnScrollChanged(Object sender, ScrollChangedEventArgs e)
        {
            if (e.VerticalChange != 0)
            {
                InputsScrollViewer.ScrollToVerticalOffset(e.VerticalOffset);
            }
        }

        private void InputsScrollViewer_OnScrollChanged(Object sender, ScrollChangedEventArgs e)
        {
            if (e.VerticalChange != 0)
            {
                TitlesScrollViewer.ScrollToVerticalOffset(e.VerticalOffset);
            }
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
                    MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите сохранить данные?",
                        "Изменение данных", MessageBoxButton.YesNo,
                        MessageBoxImage.Warning);
                    if (result == MessageBoxResult.Yes)
                    {
                        using (RequestsManagementEntities context = new RequestsManagementEntities())
                        {
                            Requests request = context.Requests.Find(_request.Id);

                            Users findedClient = DbFunctions.GetUserByLogin(ClientComboBox.Text);
                            Statuses findedStatus = DbFunctions.GetStatusByName(StatusComboBox.Text);

                            request.UserId = findedClient.Id;
                            request.StatusId = findedStatus.Id;
                            request.Equipment = EquipmentTextBox.Text;
                            request.Malfunction = MalfunctionTextBox.Text;
                            request.IssueDescription = IssueDescriptionTextBox.Text;
                            request.ExpectedCompletionDate = NewDayDatePicker.SelectedDate != null
                                ? DateTime.Parse(NewDayDatePicker.SelectedDate.ToString())
                                : DateTime.Now.AddDays(3);
                            request.ExpectedCompletionTime = TimeSpan.Parse(NewTimeTextBox.Text);

                            context.SaveChanges();
                            MessageBox.Show("Данные заявки успешно сохранены!",
                                "Успех!", MessageBoxButton.OK,
                                MessageBoxImage.Information);
                            this.Close();
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
                MessageBox.Show($"При заполнении формы заявки " +
                                $"произошли следующие проблемы:\n\n{errors}", "Внимание!",
                    MessageBoxButton.OK, MessageBoxImage.Error
                );
            }
        }
    }
}
