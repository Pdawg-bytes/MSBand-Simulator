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

namespace Microsoft_Band_Simulator.SettingControls
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Setting2 : Page
    {
        public Setting2()
        {
            this.InitializeComponent();
            Application.Current.Resources["ToggleButtonBackgroundChecked"] = new SolidColorBrush(devtheme);
            Application.Current.Resources["ToggleButtonBackgroundCheckedPointerOver"] = new SolidColorBrush(devtheme);
            Application.Current.Resources["ToggleButtonBackgroundCheckedPressed"] = new SolidColorBrush(devtheme);
        }

        public static Color devtheme;

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SettingApp), null, new SuppressNavigationTransitionInfo());
        }

        private void Setting3view_Loaded(object sender, RoutedEventArgs e)
        {
            Setting2Sidebar.Fill = new SolidColorBrush(devtheme);
            WMLabel.Foreground = new SolidColorBrush(devtheme);
            HourLabel.Foreground = new SolidColorBrush(devtheme);
            AutoSetLabel.Foreground = new SolidColorBrush(devtheme);
            HourToggle.Background = new SolidColorBrush(Color.FromArgb(100, 56, 52, 52));
            WMToggle.Background = new SolidColorBrush(Color.FromArgb(100, 56, 52, 52));
            AutoSetToggle.Background = new SolidColorBrush(Color.FromArgb(100, 56, 52, 52));
        }

        private void WMToggle_Unchecked(object sender, RoutedEventArgs e)
        {
            WMToggle.Background = new SolidColorBrush(Color.FromArgb(100, 56, 52, 52));
            WMToggleText.Text = "Off";
            WMToggleText.Foreground = new SolidColorBrush(Colors.DarkGray);
        }

        private void WMToggle_Checked(object sender, RoutedEventArgs e)
        {
            WMToggle.Background = new SolidColorBrush(devtheme);
            WMToggleText.Text = "On";
            WMToggleText.Foreground = new SolidColorBrush(Colors.White);
        }

        private void HourToggle_Unchecked(object sender, RoutedEventArgs e)
        {
            HourToggle.Background = new SolidColorBrush(Color.FromArgb(100, 56, 52, 52));
            HourToggleText.Text = "Off";
            HourToggleText.Foreground = new SolidColorBrush(Colors.DarkGray);
        }

        private void HourToggle_Checked(object sender, RoutedEventArgs e)
        {
            HourToggle.Background = new SolidColorBrush(devtheme);
            HourToggleText.Text = "On";
            HourToggleText.Foreground = new SolidColorBrush(Colors.White);
        }

        private void AutoSetToggle_Checked(object sender, RoutedEventArgs e)
        {
            AutoSetToggle.Background = new SolidColorBrush(devtheme);
            AutoSetToggleText.Text = "On";
            AutoSetToggleText.Foreground = new SolidColorBrush(Colors.White);
        }

        private void AutoSetToggle_Unchecked(object sender, RoutedEventArgs e)
        {
            AutoSetToggle.Background = new SolidColorBrush(Color.FromArgb(100, 56, 52, 52));
            AutoSetToggleText.Text = "Off";
            AutoSetToggleText.Foreground = new SolidColorBrush(Colors.DarkGray);
        }
    }
}
