using RequestsManagementService.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Windows.Controls;

namespace RequestsManagementService.Tools
{
    public static class Searching
    {
        public static void Search(List<Requests> requestsList, TextBox searchBox, ItemsControl itemsControl)
        {
            if (requestsList == null) return;

            List<Requests> filteredRequests = requestsList;

            if (!String.IsNullOrEmpty(searchBox.Text))
            {
                String searchText = searchBox.Text.ToLower();

                filteredRequests = filteredRequests.Where(r =>
                    r.Id.ToString().ToLower().Contains(searchText) ||
                    r.Equipment.ToLower().Contains(searchText) ||
                    r.Users.Name.ToLower().Contains(searchText) ||
                    r.Users.Surname.ToLower().Contains(searchText)
                ).ToList();
            }

            itemsControl.ItemsSource = filteredRequests;
        }
    }
}
