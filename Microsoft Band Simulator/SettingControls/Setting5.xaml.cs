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
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Microsoft_Band_Simulator.SettingControls
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Setting5 : Page
    {
        public Setting5()
        {
            this.InitializeComponent();
            // Setting color properties
            Application.Current.Resources["ToggleButtonBackgroundChecked"] = new SolidColorBrush(devtheme);
            Application.Current.Resources["ToggleButtonBackgroundCheckedPointerOver"] = new SolidColorBrush(devtheme);
            Application.Current.Resources["ToggleButtonBackgroundCheckedPressed"] = new SolidColorBrush(devtheme);
            Application.Current.Resources["ComboBoxBackgroundPointerOver"] = new SolidColorBrush(Color.FromArgb(255, 102, 102, 102));
        }

        public static Color devtheme;
        public static bool IsToggleOnS5;

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SettingApp), null, new SuppressNavigationTransitionInfo());
        }

        private void Setting5view_Loaded(object sender, RoutedEventArgs e)
        {
            Setting5Sidebar.Fill = new SolidColorBrush(devtheme);
            HRLabel.Foreground = new SolidColorBrush(devtheme);
            HRToggle.IsChecked = IsToggleOnS5;
            HRToggle.Background = new SolidColorBrush(Color.FromArgb(100, 56, 52, 52));
        }

        private void HRToggle_Checked(object sender, RoutedEventArgs e)
        {
            HRToggle.Background = new SolidColorBrush(devtheme);
            ToggleText.Text = "On";
            ToggleText.Foreground = new SolidColorBrush(Colors.White);
            HealthUI.HRState = true;
            DeviceSettings.HRSliderEnabled = true;
            Band2.HRIcon = new BitmapImage(new Uri("ms-appx:///Assets/Icons/heart.png"));
            IsToggleOnS5 = true;
        }

        private void HRToggle_Unchecked(object sender, RoutedEventArgs e)
        {
            HRToggle.Background = new SolidColorBrush(Color.FromArgb(100, 56, 52, 52));
            ToggleText.Text = "Off";
            ToggleText.Foreground = new SolidColorBrush(Colors.DarkGray);
            HealthUI.HRState = false;
            DeviceSettings.HRSliderEnabled = false;
            Band2.HRIcon = new BitmapImage(new Uri("ms-appx:///Assets/Icons/heart_dark.png"));
        }
    }
}
