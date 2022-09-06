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
using Microsoft_Band_Simulator.SettingControls;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media.Animation;
using Microsoft_Band_Simulator;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Microsoft_Band_Simulator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingApp : Page
    {
        public SettingApp()
        {
            // Manages ToggleButton theme color
            this.InitializeComponent();
            Application.Current.Resources["ToggleButtonBackgroundChecked"] = new SolidColorBrush(devtheme);
            Application.Current.Resources["ToggleButtonBackgroundCheckedPointerOver"] = new SolidColorBrush(devtheme);
            Application.Current.Resources["ToggleButtonBackgroundCheckedPressed"] = new SolidColorBrush(devtheme);
        }
        public static Color devtheme;

        private void Settingview_Loaded(object sender, RoutedEventArgs e)
        {
            SettingSidebar.Fill = new SolidColorBrush(devtheme);

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Band2), null, new DrillInNavigationTransitionInfo());
        }

        private void Setting1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Setting1), null, new SuppressNavigationTransitionInfo());
        }

        private void Setting3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Setting3), null, new SuppressNavigationTransitionInfo());
        }

        private void Setting4_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Setting4), null, new SuppressNavigationTransitionInfo());
        }

        private void Setting6_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Setting6), null, new SuppressNavigationTransitionInfo());
        }

        private void Setting7_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Setting7), null, new SuppressNavigationTransitionInfo());
        }
    }
}
