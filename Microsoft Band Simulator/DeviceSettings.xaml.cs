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
                    SleepApp.devtheme = Colors.DeepSkyBlue;
                    ClockApp.devtheme = Colors.DeepSkyBlue;
                    SettingApp.devtheme = Colors.DeepSkyBlue;
                    Setting1.devtheme = Colors.DeepSkyBlue;
                    Setting2.devtheme = Colors.DeepSkyBlue;
                    Setting3.devtheme = Colors.DeepSkyBlue;
                    Setting4.devtheme = Colors.DeepSkyBlue;
                    Setting5.devtheme = Colors.DeepSkyBlue;
                    Setting6.devtheme = Colors.DeepSkyBlue;
                    Setting7.devtheme = Colors.DeepSkyBlue;
                    break;
                case "Dark Cyan":
                    Band2.devtheme = Colors.DarkCyan;
                    UV.devtheme = Colors.DarkCyan;
                    SleepApp.devtheme = Colors.DarkCyan;
                    ClockApp.devtheme = Colors.DarkCyan;
                    SettingApp.devtheme = Colors.DarkCyan;
                    Setting1.devtheme = Colors.DarkCyan;
                    Setting2.devtheme = Colors.DarkCyan;
                    Setting3.devtheme = Colors.DarkCyan;
                    Setting4.devtheme = Colors.DarkCyan;
                    Setting5.devtheme = Colors.DarkCyan;
                    Setting6.devtheme = Colors.DarkCyan;
                    Setting7.devtheme = Colors.DarkCyan;
                    break;
                case "Teal":
                    Band2.devtheme = Colors.Teal;
                    UV.devtheme = Colors.Teal;
                    SleepApp.devtheme = Colors.Teal;
                    ClockApp.devtheme = Colors.Teal;
                    SettingApp.devtheme = Colors.Teal;
                    Setting1.devtheme = Colors.Teal;
                    Setting2.devtheme = Colors.Teal;
                    Setting3.devtheme = Colors.Teal;
                    Setting4.devtheme = Colors.Teal;
                    Setting5.devtheme = Colors.Teal;
                    Setting6.devtheme = Colors.Teal;
                    Setting7.devtheme = Colors.Teal;
                    break;
                case "Light Green":
                    Band2.devtheme = Colors.LimeGreen;
                    UV.devtheme = Colors.LimeGreen;
                    SleepApp.devtheme = Colors.LimeGreen;
                    ClockApp.devtheme = Colors.LimeGreen;
                    SettingApp.devtheme = Colors.LimeGreen;
                    Setting1.devtheme = Colors.LimeGreen;
                    Setting2.devtheme = Colors.LimeGreen;
                    Setting3.devtheme = Colors.LimeGreen;
                    Setting4.devtheme = Colors.LimeGreen;
                    Setting5.devtheme = Colors.LimeGreen;
                    Setting6.devtheme = Colors.LimeGreen;
                    Setting7.devtheme = Colors.LimeGreen;
                    break;
                case "Yellow Green":
                    Band2.devtheme = Colors.YellowGreen;
                    UV.devtheme = Colors.YellowGreen;
                    SleepApp.devtheme = Colors.YellowGreen;
                    ClockApp.devtheme = Colors.YellowGreen;
                    SettingApp.devtheme = Colors.YellowGreen;
                    Setting1.devtheme = Colors.YellowGreen;
                    Setting2.devtheme = Colors.YellowGreen;
                    Setting3.devtheme = Colors.YellowGreen;
                    Setting4.devtheme = Colors.YellowGreen;
                    Setting5.devtheme = Colors.YellowGreen;
                    Setting6.devtheme = Colors.YellowGreen;
                    Setting7.devtheme = Colors.YellowGreen;
                    break;
                case "Yellow":
                    Band2.devtheme = Colors.Yellow;
                    UV.devtheme = Colors.Yellow;
                    SleepApp.devtheme = Colors.Yellow;
                    ClockApp.devtheme = Colors.Yellow;
                    SettingApp.devtheme = Colors.Yellow;
                    Setting1.devtheme = Colors.Yellow;
                    Setting2.devtheme = Colors.Yellow;
                    Setting3.devtheme = Colors.Yellow;
                    Setting4.devtheme = Colors.Yellow;
                    Setting5.devtheme = Colors.Yellow;
                    Setting6.devtheme = Colors.Yellow;
                    Setting7.devtheme = Colors.Yellow;
                    break;
                case "Orange":
                    Band2.devtheme = Colors.Orange;
                    UV.devtheme = Colors.Orange;
                    SleepApp.devtheme = Colors.Orange;
                    ClockApp.devtheme = Colors.Orange;
                    SettingApp.devtheme = Colors.Orange;
                    Setting1.devtheme = Colors.Orange;
                    Setting2.devtheme = Colors.Orange;
                    Setting3.devtheme = Colors.Orange;
                    Setting4.devtheme = Colors.Orange;
                    Setting5.devtheme = Colors.Orange;
                    Setting6.devtheme = Colors.Orange;
                    Setting7.devtheme = Colors.Orange;
                    break;
                case "Red":
                    Band2.devtheme = Colors.Red;
                    UV.devtheme = Colors.Red;
                    SleepApp.devtheme = Colors.Red;
                    ClockApp.devtheme = Colors.Red;
                    SettingApp.devtheme = Colors.Red;
                    Setting1.devtheme = Colors.Red;
                    Setting2.devtheme = Colors.Red;
                    Setting3.devtheme = Colors.Red;
                    Setting4.devtheme = Colors.Red;
                    Setting5.devtheme = Colors.Red;
                    Setting6.devtheme = Colors.Red;
                    Setting7.devtheme = Colors.Red;
                    break;
                case "Hot Pink":
                    Band2.devtheme = Colors.HotPink;
                    UV.devtheme = Colors.HotPink;
                    SleepApp.devtheme = Colors.HotPink;
                    ClockApp.devtheme = Colors.HotPink;
                    SettingApp.devtheme = Colors.HotPink;
                    Setting1.devtheme = Colors.HotPink;
                    Setting2.devtheme = Colors.HotPink;
                    Setting3.devtheme = Colors.HotPink;
                    Setting4.devtheme = Colors.HotPink;
                    Setting5.devtheme = Colors.HotPink;
                    Setting6.devtheme = Colors.HotPink;
                    Setting7.devtheme = Colors.HotPink;
                    break;
                case "Magenta":
                    Band2.devtheme = Colors.DarkMagenta;
                    UV.devtheme = Colors.DarkMagenta;
                    SleepApp.devtheme = Colors.DarkMagenta;
                    ClockApp.devtheme = Colors.DarkMagenta;
                    SettingApp.devtheme = Colors.DarkMagenta;
                    Setting1.devtheme = Colors.DarkMagenta;
                    Setting2.devtheme = Colors.DarkMagenta;
                    Setting3.devtheme = Colors.DarkMagenta;
                    Setting4.devtheme = Colors.DarkMagenta;
                    Setting5.devtheme = Colors.DarkMagenta;
                    Setting6.devtheme = Colors.DarkMagenta;
                    Setting7.devtheme = Colors.DarkMagenta;
                    break;
                case "Purple":
                    Band2.devtheme = Colors.BlueViolet;
                    UV.devtheme = Colors.BlueViolet;
                    SleepApp.devtheme = Colors.BlueViolet;
                    ClockApp.devtheme = Colors.BlueViolet;
                    SettingApp.devtheme = Colors.BlueViolet;
                    Setting1.devtheme = Colors.BlueViolet;
                    Setting2.devtheme = Colors.BlueViolet;
                    Setting3.devtheme = Colors.BlueViolet;
                    Setting4.devtheme = Colors.BlueViolet;
                    Setting5.devtheme = Colors.BlueViolet;
                    Setting6.devtheme = Colors.BlueViolet;
                    Setting7.devtheme = Colors.BlueViolet;
                    break;

            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromLeft });
        }


        private void DeviceName_TextChanged(object sender, TextChangedEventArgs e)
        {
            Setting6.bandname = DeviceName.Text;
        }

        private void BatteryPercentSet_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            Band2.battery = Convert.ToInt32(e.NewValue);
        }
    }
}
