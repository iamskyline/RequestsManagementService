using RequestsManagementService.Models;
using RequestsManagementService.Tools;
using System;
using System.Text;
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
            StringBuilder errors = Validation.ValidateManagerBlank(NewDayDatePicker, NewTimeTextBox, PerformerComboBox);

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
                            Users findedPerformer = DbFunctions.GetUserByLogin(PerformerComboBox.Text);

                            ExecutionRequests newExecutionRequest = new ExecutionRequests()
                            {
                                RequestId = _request.Id,
                                UserId = findedPerformer.Id,
                                StartDate = DateTime.Now
                            };

                            context.ExecutionRequests.Add(newExecutionRequest);
                            context.SaveChanges();
                            MessageBox.Show("Заявка успешно создана!", "Успех!", MessageBoxButton.OK,
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

        private void GoBackButton_OnClick(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
