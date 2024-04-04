using RequestsManagementService.Models;
using System;
using System.Windows;

namespace RequestsManagementService.AppWindows.RolesWindows.PerformerWindows
{
    public partial class PerformerExecuteRequestWindow : Window
    {
        private Requests _request;

        public PerformerExecuteRequestWindow(Requests request)
        {
            _request = request;
            InitializeComponent();
            DataContext = _request;
        }

        private void GetToWorkButton_OnClick(Object sender, RoutedEventArgs e)
        {
            if (_request.StatusId != (Int32)RequestStatus.Finished && _request.StatusId != (Int32)RequestStatus.InExecution)
            {
                try
                {
                    using (RequestsManagementEntities context = new RequestsManagementEntities())
                    {
                        Requests request = context.Requests.Find(_request.Id);

                        request.StatusId = (Int32)RequestStatus.InExecution;

                        context.SaveChanges();

                        MessageBox.Show("Заявка взята в работу!",
                            "Успех!", MessageBoxButton.OK,
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
            {
                MessageBox.Show("Ошибка! Вы не можете взять уже завершенную " +
                                "заявку или заявку, которая уже выполняется",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
