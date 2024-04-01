﻿using System;
using RequestsManagementService.Models;
using System.Windows;
using System.Windows.Controls;
using RequestsManagementService.Tools;

namespace RequestsManagementService.AppWindows.RequestWindows
{
    public partial class EditingRequestWindow : Window
    {
        private Requests _request;

        public EditingRequestWindow(Requests request)
        {
            _request = request;
            DataContext = _request;
            InitializeComponent();

            DbFunctions.LoadDataToComboBoxes(ClientComboBox, StatusComboBox, _request);
        }

        private void TitlesScrollViewer_OnScrollChanged(Object sender, ScrollChangedEventArgs e)
        {
            if (e.VerticalChange != 0)
            {
                InputsScrollViewer.ScrollToVerticalOffset(e.VerticalOffset);
            }
        }

        private void InputsScrollViewer_OnScrollChanged(Object sender, ScrollChangedEventArgs e)
        {
            if (e.VerticalChange != 0)
            {
                TitlesScrollViewer.ScrollToVerticalOffset(e.VerticalOffset);
            }
        }

        private void GoBackButton_OnClick(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveRequestButton_OnClick(Object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
