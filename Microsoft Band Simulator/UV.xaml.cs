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

namespace Microsoft_Band_Simulator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UV : Page
    {
        public UV()
        {
            this.InitializeComponent();
            Application.Current.Resources["ToggleButtonBackgroundChecked"] = new SolidColorBrush(devtheme);
            Application.Current.Resources["ToggleButtonBackgroundCheckedPointerOver"] = new SolidColorBrush(devtheme);
            Application.Current.Resources["ToggleButtonBackgroundCheckedPressed"] = new SolidColorBrush(devtheme);
        }

        public static Color devtheme;

        private void UVview_Loaded(object sender, RoutedEventArgs e)
        {
            UVSidebar.Fill = new SolidColorBrush(devtheme);
            P1Label.Foreground = new SolidColorBrush(devtheme);
            P2Label.Foreground = new SolidColorBrush(devtheme);
        }

        private void UVToggle_Checked(object sender, RoutedEventArgs e)
        {
            UVToggle.Background = new SolidColorBrush(devtheme);
            ToggleText.Text = "On";
            ToggleText.Foreground = new SolidColorBrush(Colors.White);
        }

        private void UVToggle_Unchecked(object sender, RoutedEventArgs e)
        {
            UVToggle.Background = new SolidColorBrush(Color.FromArgb(100, 56, 52, 52));
            ToggleText.Text = "Off";
            ToggleText.Foreground = new SolidColorBrush(Colors.DarkGray);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Band2), null, new DrillInNavigationTransitionInfo());
        }
    }
}
