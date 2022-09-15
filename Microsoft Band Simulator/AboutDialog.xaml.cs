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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Microsoft_Band_Simulator
{
    public enum AboutResult
    {
        Close
    }

    public sealed partial class AboutDialog : ContentDialog
    {
        public AboutResult Result { get; set; }
        public AboutDialog()
        {
            this.InitializeComponent();
        }

        public static string AppVerDialog;
        public static string AppArchDialog;

        private void AboutCloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Result = AboutResult.Close;
            AboutDialogContent.Hide();
        }

        private void AboutDialogContent_Loaded(object sender, RoutedEventArgs e)
        {
            AppArchText.Text = AppArchDialog;
            AppVerText.Text = "Application Version: " + AppVerDialog;
        }
    }
}
