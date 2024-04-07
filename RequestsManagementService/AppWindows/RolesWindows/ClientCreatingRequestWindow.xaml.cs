using RequestsManagementService.Models;
using RequestsManagementService.Tools;
using System;
using System.ComponentModel;
using System.Text;
using System.Windows;

namespace RequestsManagementService.AppWindows.RolesWindows
{
    public partial class ClientCreatingRequestWindow : Window
    {
        public ClientCreatingRequestWindow()
        {
            InitializeComponent();
        }

        private void CreateRequestButton_OnClick(Object sender, RoutedEventArgs e)
        {
            StringBuilder errors =
                Validation.ValidateClientBlank(EquipmentTextBox, MalfunctionTextBox, IssueDescriptionTextBox);

            if (errors.Length == 0)
            {
                try
                {
                    using (RequestsManagementEntities context = new RequestsManagementEntities())
                    {
                        String expectedTime = "12:00:00";
                        
                        Requests newRequest = new Requests()
                        {
                            UserId = Storage.SystemUser.Id,
                            StatusId = (Int32)RequestStatus.InProcessing,
                            CreatedDate = DateTime.Now,
                            Equipment = EquipmentTextBox.Text,
                            Malfunction = MalfunctionTextBox.Text,
                            IssueDescription = IssueDescriptionTextBox.Text,
                            ExpectedCompletionDate = DateTime.Now.AddDays(3),
                            ExpectedCompletionTime = TimeSpan.Parse(expectedTime)
                        };

                        context.Requests.Add(newRequest);
                        context.SaveChanges();
                        MessageBox.Show("Заявка успешно отправлена!", "Успех!", MessageBoxButton.OK,
                            MessageBoxImage.Information);
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

        private void ClientCreatingRequestWindow_OnClosing(Object sender, CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
