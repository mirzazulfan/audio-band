﻿using System.Windows;
using System.Windows.Media;
using AudioBand.ViewModels;

namespace AudioBand.Views.Wpf
{
    /// <summary>
    /// Implementation of <see cref="IDialogService"/>.
    /// </summary>
    public class DialogService : IDialogService
    {
        /// <inheritdoc/>
        public Color? ShowColorPickerDialog(Color initialColor)
        {
            var colorPickerDialog = new Dsafa.WpfColorPicker.ColorPickerDialog(initialColor)
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.NoResize
            };

            var res = colorPickerDialog.ShowDialog();
            if (res.HasValue && res.Value)
            {
                return colorPickerDialog.Color;
            }

            return null;
        }

        /// <inheritdoc/>
        public bool ShowConfirmationDialog(string title, string message)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show(message, title, MessageBoxButton.YesNo);
            return messageBoxResult == MessageBoxResult.Yes;
        }
    }
}
