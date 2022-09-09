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
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Media.Imaging;

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

        public static string devthemeSetting;

        private void ThemeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string themeName = e.AddedItems[0].ToString();
            switch (themeName)
            {
                case "Microsoft Blue":
                default:
                    Band2.devtheme = Colors.DeepSkyBlue;
                    devthemeSetting = "Microsoft Blue";
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
                    devthemeSetting = "Dark Cyan";
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
                    devthemeSetting = "Teal";
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
                    devthemeSetting = "Light Green";
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
                    devthemeSetting = "Yellow Green";
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
                    Band2.devtheme = Colors.Goldenrod;
                    devthemeSetting = "Yellow";
                    UV.devtheme = Colors.Goldenrod;
                    SleepApp.devtheme = Colors.Goldenrod;
                    ClockApp.devtheme = Colors.Goldenrod;
                    SettingApp.devtheme = Colors.Goldenrod;
                    Setting1.devtheme = Colors.Goldenrod;
                    Setting2.devtheme = Colors.Goldenrod;
                    Setting3.devtheme = Colors.Goldenrod;
                    Setting4.devtheme = Colors.Goldenrod;
                    Setting5.devtheme = Colors.Goldenrod;
                    Setting6.devtheme = Colors.Goldenrod;
                    Setting7.devtheme = Colors.Goldenrod;
                    break;
                case "Orange":
                    Band2.devtheme = Colors.Orange;
                    devthemeSetting = "Orange";
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
                    devthemeSetting = "Red";
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
                case "Pink":
                    Band2.devtheme = Colors.HotPink;
                    devthemeSetting = "Pink";
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
                    devthemeSetting = "Magenta";
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
                    devthemeSetting = "Purple";
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

        private void WallpaperComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string wallName = e.AddedItems[0].ToString();
            switch (devthemeSetting)
            {
                case "Microsoft Blue":
                    switch (wallName)
                    {
                        case "Blank":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/electric_blank.png"));
                            break;
                        case "Chevs":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/electric_chevs.png"));
                            break;
                        case "Curves":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/electric_curves.png"));
                            break;
                        case "Dan":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/electric_dan.png"));
                            break;
                        case "Fast":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/electric_fast.png"));
                            break;
                        case "Fiber":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/electric_fiber.png"));
                            break;
                        case "Forward":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/electric_fwd.png"));
                            break;
                        case "Dark":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/electric_noods.png"));
                            break;
                        case "Plates":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/electric_plates.png"));
                            break;
                        case "Time":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/electric_time.png"));
                            break;
                    }
                    break;
                case "Dark Cyan":
                    switch (wallName)
                    {
                        case "Blank":
                            break;
                        case "Chevs":
                            break;
                        case "Curves":
                            break;
                        case "Dan":
                            break;
                        case "Fast":
                            break;
                        case "Fiber":
                            break;
                        case "Forward":
                            break;
                        case "Dark":
                            break;
                        case "Plates":
                            break;
                        case "Time":
                            break;
                    }
                    break;
                case "Teal":
                    switch (wallName)
                    {
                        case "Blank":
                            break;
                        case "Chevs":
                            break;
                        case "Curves":
                            break;
                        case "Dan":
                            break;
                        case "Fast":
                            break;
                        case "Fiber":
                            break;
                        case "Forward":
                            break;
                        case "Dark":
                            break;
                        case "Plates":
                            break;
                        case "Time":
                            break;
                    }
                    break;
                case "Light Green":
                    switch (wallName)
                    {
                        case "Blank":
                            break;
                        case "Chevs":
                            break;
                        case "Curves":
                            break;
                        case "Dan":
                            break;
                        case "Fast":
                            break;
                        case "Fiber":
                            break;
                        case "Forward":
                            break;
                        case "Dark":
                            break;
                        case "Plates":
                            break;
                        case "Time":
                            break;
                    }
                    break;
                case "Yellow Green":
                    switch (wallName)
                    {
                        case "Blank":
                            break;
                        case "Chevs":
                            break;
                        case "Curves":
                            break;
                        case "Dan":
                            break;
                        case "Fast":
                            break;
                        case "Fiber":
                            break;
                        case "Forward":
                            break;
                        case "Dark":
                            break;
                        case "Plates":
                            break;
                        case "Time":
                            break;
                    }
                    break;
                case "Yellow":
                    switch (wallName)
                    {
                        case "Blank":
                            break;
                        case "Chevs":
                            break;
                        case "Curves":
                            break;
                        case "Dan":
                            break;
                        case "Fast":
                            break;
                        case "Fiber":
                            break;
                        case "Forward":
                            break;
                        case "Dark":
                            break;
                        case "Plates":
                            break;
                        case "Time":
                            break;
                    }
                    break;
                case "Orange":
                    switch (wallName)
                    {
                        case "Blank":
                            break;
                        case "Chevs":
                            break;
                        case "Curves":
                            break;
                        case "Dan":
                            break;
                        case "Fast":
                            break;
                        case "Fiber":
                            break;
                        case "Forward":
                            break;
                        case "Dark":
                            break;
                        case "Plates":
                            break;
                        case "Time":
                            break;
                    }
                    break;
                case "Red":
                    switch (wallName)
                    {
                        case "Blank":
                            break;
                        case "Chevs":
                            break;
                        case "Curves":
                            break;
                        case "Dan":
                            break;
                        case "Fast":
                            break;
                        case "Fiber":
                            break;
                        case "Forward":
                            break;
                        case "Dark":
                            break;
                        case "Plates":
                            break;
                        case "Time":
                            break;
                    }
                    break;
                case "Pink":
                    switch (wallName)
                    {
                        case "Blank":
                            break;
                        case "Chevs":
                            break;
                        case "Curves":
                            break;
                        case "Dan":
                            break;
                        case "Fast":
                            break;
                        case "Fiber":
                            break;
                        case "Forward":
                            break;
                        case "Dark":
                            break;
                        case "Plates":
                            break;
                        case "Time":
                            break;
                    }
                    break;
                case "Magenta":
                    switch (wallName)
                    {
                        case "Blank":
                            break;
                        case "Chevs":
                            break;
                        case "Curves":
                            break;
                        case "Dan":
                            break;
                        case "Fast":
                            break;
                        case "Fiber":
                            break;
                        case "Forward":
                            break;
                        case "Dark":
                            break;
                        case "Plates":
                            break;
                        case "Time":
                            break;
                    }
                    break;
                case "Purple":
                    switch (wallName)
                    {
                        case "Blank":
                            break;
                        case "Chevs":
                            break;
                        case "Curves":
                            break;
                        case "Dan":
                            break;
                        case "Fast":
                            break;
                        case "Fiber":
                            break;
                        case "Forward":
                            break;
                        case "Dark":
                            break;
                        case "Plates":
                            break;
                        case "Time":
                            break;
                    }
                    break;
            }
        }
    }
}
