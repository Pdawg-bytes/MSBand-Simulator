using Microsoft_Band_Simulator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Microsoft_Band_Simulator
{
    // Define your own ContentDialogResult enum
    public enum NotifResult
    {
        Create,
        Cancel
    }

    public sealed partial class NewNotificationDialog : ContentDialog
    {
        public NotifResult Result { get; set; }
        public NewNotificationDialog()
        {
            this.InitializeComponent();
            CreateButton.IsEnabled = false;
            NotificationContent.Text = "";
            NotificationTitleBox.Text = "";
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            this.Result = NotifResult.Create;
            // Close the dialog
            NotifDialog.Hide();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Result = NotifResult.Cancel;
            // Close the dialog
            NotifDialog.Hide();
        }

        private void NotificationContent_TextChanged(object sender, TextChangedEventArgs e)
        {
            CreateButton.IsEnabled = (NotificationContent.Text != "") && (NotificationTitleBox.Text != "");
            NotificationTemplate.NotifContent = NotificationContent.Text;
        }
        private void NotificationTitleBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CreateButton.IsEnabled = (NotificationContent.Text != "") && (NotificationTitleBox.Text != "");
            NotificationTemplate.NotifTitle = NotificationTitleBox.Text;
        }
    }
}
