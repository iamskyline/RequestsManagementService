using RequestsManagementService.Models;
using System;
using System.Windows;

namespace RequestsManagementService.AppWindows.RolesWindows.PerformerWindows
{
    public partial class PerformerCommentWindow : Window
    {
        private Requests _request;

        public PerformerCommentWindow(Requests request)
        {
            InitializeComponent();
            _request = request;
            DataContext = _request;
        }

        private void SaveCommentButton_OnClick(Object sender, RoutedEventArgs e)
        {
            if (CommentTextBox.Text.Length > 0)
            {
                try
                {
                    using (RequestsManagementEntities context = new RequestsManagementEntities())
                    {
                        Requests request = context.Requests.Find(_request.Id);
                        
                        request.UserDescription = CommentTextBox.Text;

                        context.SaveChanges();
                        MessageBox.Show("Данные заявки успешно сохранены!",
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
                MessageBox.Show("Ошибка! Вы не заполнили поле комментария!",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
