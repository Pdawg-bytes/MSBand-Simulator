using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Microsoft_Band_Simulator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            // Inits frame and navigates to it in MainWindow
            Band2Frame.Navigate(typeof(Band2), null, new SuppressNavigationTransitionInfo());
            Band2Frame.Visibility = Visibility.Visible;
            pwon.IsEnabled = false;
        }

        private void OffButton_Click(object sender, RoutedEventArgs e)
        {
            // Will hide frame and re-enable pwon button
            pwon.IsEnabled = true;
            Band2Frame.Visibility = Visibility.Collapsed;
        }

        private void DevSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DeviceSettings), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
        }
    }
}
