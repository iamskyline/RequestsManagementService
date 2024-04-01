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

        public static List<String> GetAllClientsLogins()
        {
            return RequestsManagementEntities.GetContext().Users.Where(u => u.RoleId == 4).Select(u => u.Login).ToList();
        }

        public static List<String> GetAllStatusNames()
        {
            return RequestsManagementEntities.GetContext().Statuses.Select(s => s.Name).ToList();
        }
    }
}
