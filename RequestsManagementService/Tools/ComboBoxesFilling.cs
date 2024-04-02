using RequestsManagementService.Models;
using System.Collections.Generic;
using System.Windows.Controls;
using System;
using System.Linq;

namespace RequestsManagementService.Tools
{
    public static class ComboBoxesFilling
    {
        public static void FillClientsToComboBoxes(ComboBox comboBox, Requests request)
        {
            Users user = DbFunctions.GetClientById(request.UserId);
            if (user != null)
                comboBox.SelectedItem = user.Login;

            comboBox.ItemsSource = DbFunctions.GetAllClientsLogins();
        }

        public static void FillClientsToComboBoxes(ComboBox comboBox)
        {
            comboBox.SelectedIndex = 0;
            comboBox.ItemsSource = DbFunctions.GetAllClientsLogins();
        }

        public static void FillStatusesToComboBox(ComboBox comboBox)
        {
            comboBox.SelectedIndex = 0;
            comboBox.ItemsSource = DbFunctions.GetAllStatusNames();
        }

        public static void FillPerformersToComboBox(ComboBox comboBox)
        {
            List<String> performers = DbFunctions.GetAllPerformers().Select(u => u.Login).ToList();
            performers.Insert(0, "не выбран");
            comboBox.SelectedIndex = 0;
            comboBox.ItemsSource = performers;
        }
    }
}
