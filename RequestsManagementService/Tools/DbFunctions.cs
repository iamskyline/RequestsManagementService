using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using RequestsManagementService.Models;

namespace RequestsManagementService.Tools
{
    public static class DbFunctions
    {
        public static void LoadRequestsToItemsControl(ItemsControl itemsControl)
        {
            itemsControl.ItemsSource = RequestsManagementEntities.GetContext().Requests.ToList();
        }

        public static List<Users> GetAllClients()
        {
            return RequestsManagementEntities.GetContext().Users.Where(u => u.RoleId == 4).ToList();
        }

        public static List<Users> GetAllPerformers()
        {
            return RequestsManagementEntities.GetContext().Users.Where(u => u.RoleId == 3).ToList();
        }

        public static Users GetClientById(Int32 id)
        {
            return RequestsManagementEntities.GetContext().Users.Where(u => u.RoleId == 4).FirstOrDefault(u => u.Id == id);
        }

        public static List<String> GetAllClientsLogins()
        {
            return RequestsManagementEntities.GetContext().Users.Where(u => u.RoleId == 4).Select(u => u.Login).ToList();
        }

        public static List<String> GetAllStatusNames()
        {
            return RequestsManagementEntities.GetContext().Statuses.Select(s => s.Name).ToList();
        }

        public static void FillClientsToComboBoxes(ComboBox comboBox, Requests request)
        {
            Users user = GetClientById(request.UserId);
            if (user != null)
                comboBox.SelectedItem = user.Login;

            comboBox.ItemsSource = GetAllClientsLogins();
        }

        public static void FillClientsToComboBoxes(ComboBox comboBox)
        {
            comboBox.SelectedIndex = 0;
            comboBox.ItemsSource = GetAllClientsLogins();
        }

        public static void FillStatusesToComboBox(ComboBox comboBox)
        {
            comboBox.SelectedIndex = 0;
            comboBox.ItemsSource = GetAllStatusNames();
        }

        public static void FillPerformersToComboBox(ComboBox comboBox)
        {
            List<String> performers = GetAllPerformers().Select(u => u.Login).ToList();
            performers.Insert(0, "не выбран");
            comboBox.SelectedIndex = 0;
            comboBox.ItemsSource = performers;
        }

        public static Int32 CountAllRequests()
        {
            return RequestsManagementEntities.GetContext().Requests.Count();
        }

        public static Int32 CountFinishedRequests()
        {
            return RequestsManagementEntities.GetContext().Requests.Count(r => r.StatusId == 3);
        }

        public static Int32 CountRequestsInProcessing()
        {
            return RequestsManagementEntities.GetContext().Requests.Count(r => r.StatusId == 1);
        }

        public static Int32 CountRequestsInExecutionProcess()
        {
            return RequestsManagementEntities.GetContext().Requests.Count(r => r.StatusId == 2);
        }

        public static Int32 CountRequestsInPartiallyCompleted()
        {
            return RequestsManagementEntities.GetContext().Requests.Count(r => r.StatusId == 4);
        }
    }
}
