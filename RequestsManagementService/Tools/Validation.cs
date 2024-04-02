using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace RequestsManagementService.Tools
{
    public static class Validation
    {
        public static StringBuilder ValidateAdminBlank(
            ComboBox clientComboBox, ComboBox statusComboBox,
            TextBox equipmentTextBox, TextBox malfunctionTextBox,
            TextBox newTimeTextBox, DatePicker newDayDatePicker
        )
        {
            StringBuilder errors = new StringBuilder();

            if (clientComboBox.SelectedItem == null) errors.AppendLine("Выберите клиента!");
            if (statusComboBox.SelectedItem == null) errors.AppendLine("Выберите статус заявки!");
            if (equipmentTextBox.Text == "") errors.AppendLine("Заполните поле оборудования!");
            if (malfunctionTextBox.Text == "") errors.AppendLine("Заполните поле неисправности!");
            if (newTimeTextBox.Text == "") errors.AppendLine("Заполните поле ожидаемого времени завершения работ!");
            if (newDayDatePicker.SelectedDate < DateTime.Now)
                errors.AppendLine("Время ожидаемого завершения работ не может быть раньше текущей даты!");

            String timePattern = @"^(?:[01]\d|2[0-3]):[0-5]\d:[0-5]\d$"; // Регулярное выражение для формата времени "00:00:00"
            if (!Regex.IsMatch(newTimeTextBox.Text, timePattern))
            {
                errors.AppendLine("Неправильный формат времени. Пожалуйста, введите время в формате '00:00:00'.");
            }

            return errors;
        }

        public static StringBuilder ValidateManagerBlank(DatePicker datePicker, TextBox timeTextBox, ComboBox performerComboBox)
        {
            StringBuilder errors = new StringBuilder();

            if (datePicker.SelectedDate == null) errors.AppendLine("Выберите дату!");
            if (performerComboBox.SelectedIndex == 0) errors.AppendLine("Выберите исполнителя!");

            String timePattern = @"^(?:[01]\d|2[0-3]):[0-5]\d:[0-5]\d$"; // Регулярное выражение для формата времени "00:00:00"
            if (!Regex.IsMatch(timeTextBox.Text, timePattern))
            {
                errors.AppendLine("Неправильный формат времени. Пожалуйста, введите время в формате '00:00:00'.");
            }

            return errors;
        }

        public static StringBuilder ValidateClientBlank(TextBox equipmentTextBox, TextBox malfunctionTextBox, TextBox issueDescriptionTextBox)
        {
            StringBuilder errors = new StringBuilder();

            if (equipmentTextBox.Text == "") errors.AppendLine("Заполните поле оборудования!");
            if (malfunctionTextBox.Text == "") errors.AppendLine("Заполните поле поломки!");
            if (issueDescriptionTextBox.Text == "") errors.AppendLine("Заполните поле описание проблемы!");
            
            return errors;
        }
    }
}
