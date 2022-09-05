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
    public sealed partial class Setting1 : Page
    {
        public Setting1()
        {
            this.InitializeComponent();
            // Setting ToggleButton color properties
            Application.Current.Resources["ToggleButtonBackgroundChecked"] = new SolidColorBrush(devtheme);
            Application.Current.Resources["ToggleButtonBackgroundCheckedPointerOver"] = new SolidColorBrush(devtheme);
            Application.Current.Resources["ToggleButtonBackgroundCheckedPressed"] = new SolidColorBrush(devtheme);
        }
        public static Color devtheme;

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SettingApp), null, new SuppressNavigationTransitionInfo());
        }

        private void Setting1view_Loaded(object sender, RoutedEventArgs e)
        {
            Setting1Sidebar.Fill = new SolidColorBrush(devtheme);
            DNDLabel.Foreground = new SolidColorBrush(devtheme);
            DNDToggle.Background = new SolidColorBrush(Color.FromArgb(100, 56, 52, 52));
        }

        private void DNDToggle_Checked(object sender, RoutedEventArgs e)
        {
            DNDToggle.Background = new SolidColorBrush(devtheme);
            ToggleText.Text = "On";
            ToggleText.Foreground = new SolidColorBrush(Colors.White);
        }

        private void DNDToggle_Unchecked(object sender, RoutedEventArgs e)
        {
            DNDToggle.Background = new SolidColorBrush(Color.FromArgb(100, 56, 52, 52));
            ToggleText.Text = "Off";
            ToggleText.Foreground = new SolidColorBrush(Colors.DarkGray);
        }
    }
}
