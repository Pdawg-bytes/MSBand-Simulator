using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Microsoft_Band_Simulator.SettingControls;
using System.Diagnostics;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Runtime.CompilerServices;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Microsoft_Band_Simulator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DeviceSettings : Page
    {
        public DeviceSettings()
        {
            this.InitializeComponent();
        }

        private void ThemeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string themeName = e.AddedItems[0].ToString();
            switch (themeName)
            {
                case "Microsoft Blue":
                default:
                    Band2.devtheme = Colors.DeepSkyBlue;
                    UV.devtheme = Colors.DeepSkyBlue;
                    SettingApp.devtheme = Colors.DeepSkyBlue;
                    Setting1.devtheme = Colors.DeepSkyBlue;
                    break;
                case "Dark Cyan":
                    Band2.devtheme = Colors.DarkCyan;
                    UV.devtheme = Colors.DarkCyan;
                    SettingApp.devtheme = Colors.DarkCyan;
                    Setting1.devtheme = Colors.DarkCyan;
                    break;
                case "Teal":
                    Band2.devtheme = Colors.Teal;
                    UV.devtheme = Colors.Teal;
                    SettingApp.devtheme = Colors.Teal;
                    Setting1.devtheme = Colors.Teal;
                    break;
                case "Light Green":
                    Band2.devtheme = Colors.LimeGreen;
                    UV.devtheme = Colors.LimeGreen;
                    SettingApp.devtheme = Colors.LimeGreen;
                    Setting1.devtheme = Colors.LimeGreen;
                    break;
                case "Yellow Green":
                    Band2.devtheme = Colors.YellowGreen;
                    UV.devtheme = Colors.YellowGreen;
                    SettingApp.devtheme = Colors.YellowGreen;
                    Setting1.devtheme = Colors.YellowGreen;
                    break;
                case "Yellow":
                    Band2.devtheme = Colors.Yellow;
                    UV.devtheme = Colors.Yellow;
                    SettingApp.devtheme = Colors.Yellow;
                    Setting1.devtheme = Colors.Yellow;
                    break;
                case "Orange":
                    Band2.devtheme = Colors.Orange;
                    UV.devtheme = Colors.Orange;
                    SettingApp.devtheme = Colors.Orange;
                    Setting1.devtheme = Colors.Orange;
                    break;
                case "Red":
                    Band2.devtheme = Colors.Red;
                    UV.devtheme = Colors.Red;
                    SettingApp.devtheme = Colors.Red;
                    Setting1.devtheme = Colors.Red;
                    break;
                case "Hot Pink":
                    Band2.devtheme = Colors.HotPink;
                    UV.devtheme = Colors.HotPink;
                    SettingApp.devtheme = Colors.HotPink;
                    Setting1.devtheme = Colors.HotPink;
                    break;
                case "Magenta":
                    Band2.devtheme = Colors.DarkMagenta;
                    UV.devtheme = Colors.DarkMagenta;
                    SettingApp.devtheme = Colors.DarkMagenta;
                    Setting1.devtheme = Colors.DarkMagenta;
                    break;
                case "Purple":
                    Band2.devtheme = Colors.BlueViolet;
                    UV.devtheme = Colors.BlueViolet;
                    SettingApp.devtheme = Colors.BlueViolet;
                    Setting1.devtheme = Colors.BlueViolet;
                    break;

            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromLeft });
        }


        private void DeviceName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BatteryPercentSet_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            Band2.battery = Convert.ToInt32(e.NewValue);
        }
    }
}
