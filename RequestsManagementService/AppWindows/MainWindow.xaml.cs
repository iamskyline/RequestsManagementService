using RequestsManagementService.AppWindows.RolesWindows.PerformerWindows;
using System;
using System.Linq;
using System.Windows;
using RequestsManagementService.AppWindows.RolesWindows;
using RequestsManagementService.AppWindows.RolesWindows.AdminWindows;
using RequestsManagementService.AppWindows.RolesWindows.ManagerWindows;
using RequestsManagementService.Models;

namespace RequestsManagementService.AppWindows
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignInButton_OnClick(Object sender, RoutedEventArgs e)
        {
            String login = LoginTextBox.Text;
            String password = PasswordTextBox.Password;

            Users user = RequestsManagementEntities.GetContext().Users
                .FirstOrDefault(u => u.Login == login && u.Password == password);

            if (user == null)
            {
                MessageBox.Show("Пользователя с таким логином и паролем не существует в системе!",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Storage.SystemUser = user;

            Window window = new Window();

            switch ((UserRole)user.RoleId)
            {
                case UserRole.Admin:
                    window = new AdminRequestsWindow();
                    break;
                case UserRole.Manager:
                    window = new ManagerRequestsWindow();
                    break;
                case UserRole.Performer:
                    window = new PerformerRequestsWindow();
                    break;
                case UserRole.Client:
                    window = new ClientCreatingRequestWindow();
                    break;
            }
            
            window.Show();
            this.Close();
        }
    }
}
