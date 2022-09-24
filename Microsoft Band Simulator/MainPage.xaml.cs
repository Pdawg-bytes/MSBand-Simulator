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
using System.Diagnostics;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media.Animation;
using Microsoft_Band_Simulator;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Microsoft_Band_Simulator
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            NotificationButton.IsEnabled = false;
        }

        public static bool ResTeachOpen;
        public static int batcompare;

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            // Inits frame and navigates to it in MainWindow
            if (batcompare <= 15)
            {
                Band2Frame.Navigate(typeof(LowBattery), null, new SuppressNavigationTransitionInfo());
            }
            else
            {
                Band2Frame.Navigate(typeof(Band2), null, new SuppressNavigationTransitionInfo());
            }
            Band2Frame.Visibility = Visibility.Visible;
            pwon.IsEnabled = false;
            NotificationButton.IsEnabled = true;
        }

        private void OffButton_Click(object sender, RoutedEventArgs e)
        {
            // Will hide frame and re-enable pwon button
            pwon.IsEnabled = true;
            Band2Frame.Visibility = Visibility.Collapsed;
            NotificationButton.IsEnabled = false;
        }

        private void DevSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DeviceSettings), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
        }

        private async void NotificationButton_Click(object sender, RoutedEventArgs e)
        {
            // Show the custom dialog
            NewNotificationDialog dialog = new NewNotificationDialog();
            await dialog.ShowAsync();

            if (dialog.Result == NotifResult.Create)
            {
                Band2Frame.Navigate(typeof(NotificationTemplate), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
                // Add actions

            }
            else if (dialog.Result == NotifResult.Cancel)
            {
                // Do nothing
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ResTeachingTip.IsOpen = ResTeachOpen;
        }

        private async void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            AboutDialog dialog = new AboutDialog();
            await dialog.ShowAsync();
        }

        private void ResTeachingTip_ActionButtonClick(Microsoft.UI.Xaml.Controls.TeachingTip sender, object args)
        {
            ResTeachingTip.IsOpen = false;
        }
    }
}
