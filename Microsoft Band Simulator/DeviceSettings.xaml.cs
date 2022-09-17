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
using System.Threading;

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
                    HealthUI.devtheme = Colors.DeepSkyBlue;
                    NotificationTemplate.devtheme = Colors.DeepSkyBlue;
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
                    Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/electric_time.png"));
                    break;
                case "Dark Cyan":
                    Band2.devtheme = Colors.DarkCyan;
                    devthemeSetting = "Dark Cyan";
                    UV.devtheme = Colors.DarkCyan;
                    HealthUI.devtheme = Colors.DarkCyan;
                    NotificationTemplate.devtheme = Colors.DarkCyan;
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
                    Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/skyline_time.png"));
                    break;
                case "Teal":
                    Band2.devtheme = Colors.Teal;
                    devthemeSetting = "Teal";
                    UV.devtheme = Colors.Teal;
                    HealthUI.devtheme = Colors.Teal;
                    NotificationTemplate.devtheme = Colors.Teal;
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
                    Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/kale_time.png"));
                    break;
                case "Light Green":
                    Band2.devtheme = Colors.LimeGreen;
                    devthemeSetting = "Light Green";
                    UV.devtheme = Colors.LimeGreen;
                    HealthUI.devtheme = Colors.LimeGreen;
                    NotificationTemplate.devtheme = Colors.LimeGreen;
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
                    Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cyber_time.png"));
                    break;
                case "Yellow Green":
                    Band2.devtheme = Colors.YellowGreen;
                    devthemeSetting = "Yellow Green";
                    UV.devtheme = Colors.YellowGreen;
                    HealthUI.devtheme = Colors.YellowGreen;
                    NotificationTemplate.devtheme = Colors.YellowGreen;
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
                    Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/lime_time.png"));
                    break;
                case "Yellow":
                    Band2.devtheme = Colors.Goldenrod;
                    devthemeSetting = "Yellow";
                    UV.devtheme = Colors.Goldenrod;
                    HealthUI.devtheme = Colors.Goldenrod;
                    NotificationTemplate.devtheme = Colors.Goldenrod;
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
                    Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tangerine_time.png"));
                    break;
                case "Orange":
                    Band2.devtheme = Colors.OrangeRed;
                    devthemeSetting = "Orange";
                    UV.devtheme = Colors.OrangeRed;
                    HealthUI.devtheme = Colors.OrangeRed;
                    NotificationTemplate.devtheme = Colors.OrangeRed;
                    SleepApp.devtheme = Colors.OrangeRed;
                    ClockApp.devtheme = Colors.OrangeRed;
                    SettingApp.devtheme = Colors.OrangeRed;
                    Setting1.devtheme = Colors.OrangeRed;
                    Setting2.devtheme = Colors.OrangeRed;
                    Setting3.devtheme = Colors.OrangeRed;
                    Setting4.devtheme = Colors.OrangeRed;
                    Setting5.devtheme = Colors.OrangeRed;
                    Setting6.devtheme = Colors.OrangeRed;
                    Setting7.devtheme = Colors.OrangeRed;
                    Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tang_time.png"));
                    break;
                case "Red":
                    Band2.devtheme = Colors.Red;
                    devthemeSetting = "Red";
                    UV.devtheme = Colors.Red;
                    HealthUI.devtheme = Colors.Red;
                    NotificationTemplate.devtheme = Colors.Red;
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
                    Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/coral_time.png"));
                    break;
                case "Pink":
                    Band2.devtheme = Colors.HotPink;
                    devthemeSetting = "Pink";
                    UV.devtheme = Colors.HotPink;
                    HealthUI.devtheme = Colors.HotPink;
                    NotificationTemplate.devtheme = Colors.HotPink;
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
                    Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/koolaid_time.png"));
                    break;
                case "Magenta":
                    Band2.devtheme = Colors.DarkMagenta;
                    devthemeSetting = "Magenta";
                    UV.devtheme = Colors.DarkMagenta;
                    HealthUI.devtheme = Colors.DarkMagenta;
                    NotificationTemplate.devtheme = Colors.DarkMagenta;
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
                    Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/berry_time.png"));
                    break;
                case "Purple":
                    Band2.devtheme = Colors.BlueViolet;
                    devthemeSetting = "Purple";
                    UV.devtheme = Colors.BlueViolet;
                    HealthUI.devtheme = Colors.BlueViolet;
                    NotificationTemplate.devtheme = Colors.BlueViolet;
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
                    Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cargo_time.png"));
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
                default:
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
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/skyline_blank.png"));
                            break;
                        case "Chevs":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/skyline_chevs.png"));
                            break;
                        case "Curves":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/skyline_curves.png"));
                            break;
                        case "Dan":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/skyline_dan.png"));
                            break;
                        case "Fast":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/skyline_fast.png"));
                            break;
                        case "Fiber":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/skyline_fiber.png"));
                            break;
                        case "Forward":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/skyline_fwd.png"));
                            break;
                        case "Dark":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/skyline_noods.png"));
                            break;
                        case "Plates":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/skyline_plates.png"));
                            break;
                        case "Time":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/skyline_time.png"));
                            break;
                    }
                    break;
                case "Teal":
                    switch (wallName)
                    {
                        case "Blank":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/kale_blank.png"));
                            break;
                        case "Chevs":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/kale_chevs.png"));
                            break;
                        case "Curves":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/kale_curves.png"));
                            break;
                        case "Dan":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/kale_dan.png"));
                            break;
                        case "Fast":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/kale_fast.png"));
                            break;
                        case "Fiber":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/kale_fiber.png"));
                            break;
                        case "Forward":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/kale_fwd.png"));
                            break;
                        case "Dark":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/kale_noods.png"));
                            break;
                        case "Plates":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/kale_plates.png"));
                            break;
                        case "Time":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/kale_time.png"));
                            break;
                    }
                    break;
                case "Light Green":
                    switch (wallName)
                    {
                        case "Blank":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cyber_blank.png"));
                            break;
                        case "Chevs":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cyber_chevs.png"));
                            break;
                        case "Curves":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cyber_curves.png"));
                            break;
                        case "Dan":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cyber_dan.png"));
                            break;
                        case "Fast":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cyber_fast.png"));
                            break;
                        case "Fiber":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cyber_fiber.png"));
                            break;
                        case "Forward":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cyber_fwd.png"));
                            break;
                        case "Dark":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cyber_noods.png"));
                            break;
                        case "Plates":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cyber_plates.png"));
                            break;
                        case "Time":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cyber_time.png"));
                            break;
                    }
                    break;
                case "Yellow Green":
                    switch (wallName)
                    {
                        case "Blank":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/lime_blank.png"));
                            break;
                        case "Chevs":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/lime_chevs.png"));
                            break;
                        case "Curves":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/lime_curves.png"));
                            break;
                        case "Dan":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/lime_dan.png"));
                            break;
                        case "Fast":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/lime_fast.png"));
                            break;
                        case "Fiber":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/lime_fiber.png"));
                            break;
                        case "Forward":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/lime_fwd.png"));
                            break;
                        case "Dark":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/lime_noods.png"));
                            break;
                        case "Plates":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/lime_plates.png"));
                            break;
                        case "Time":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/lime_time.png"));
                            break;
                    }
                    break;
                case "Yellow":
                    switch (wallName)
                    {
                        case "Blank":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tangerine_blank.png"));
                            break;
                        case "Chevs":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tangerine_chevs.png"));
                            break;
                        case "Curves":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tangerine_curves.png"));
                            break;
                        case "Dan":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tangerine_dan.png"));
                            break;
                        case "Fast":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tangerine_fast.png"));
                            break;
                        case "Fiber":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tangerine_fiber.png"));
                            break;
                        case "Forward":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tangerine_fwd.png"));
                            break;
                        case "Dark":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tangerine_noods.png"));
                            break;
                        case "Plates":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tangerine_plates.png"));
                            break;
                        case "Time":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tangerine_time.png"));
                            break;
                    }
                    break;
                case "Orange":
                    switch (wallName)
                    {
                        case "Blank":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tang_blank.png"));
                            break;
                        case "Chevs":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tang_chevs.png"));
                            break;
                        case "Curves":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tang_curves.png"));
                            break;
                        case "Dan":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tang_dan.png"));
                            break;
                        case "Fast":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tang_fast.png"));
                            break;
                        case "Fiber":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tang_fiber.png"));
                            break;
                        case "Forward":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tang_fwd.png"));
                            break;
                        case "Dark":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tang_noods.png"));
                            break;
                        case "Plates":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tang_plates.png"));
                            break;
                        case "Time":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/tang_time.png"));
                            break;
                    }
                    break;
                case "Red":
                    switch (wallName)
                    {
                        case "Blank":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/coral_blank.png"));
                            break;
                        case "Chevs":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/coral_chevs.png"));
                            break;
                        case "Curves":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/coral_curves.png"));
                            break;
                        case "Dan":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/coral_dan.png"));
                            break;
                        case "Fast":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/coral_fast.png"));
                            break;
                        case "Fiber":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/coral_fiber.png"));
                            break;
                        case "Forward":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/coral_fwd.png"));
                            break;
                        case "Dark":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/coral_noods.png"));
                            break;
                        case "Plates":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/coral_plates.png"));
                            break;
                        case "Time":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/coral_time.png"));
                            break;
                    }
                    break;
                case "Pink":
                    switch (wallName)
                    {
                        case "Blank":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/koolaid_blank.png"));
                            break;
                        case "Chevs":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/koolaid_chevs.png"));
                            break;
                        case "Curves":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/koolaid_curves.png"));
                            break;
                        case "Dan":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/koolaid_dan.png"));
                            break;
                        case "Fast":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/koolaid_fast.png"));
                            break;
                        case "Fiber":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/koolaid_fiber.png"));
                            break;
                        case "Forward":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/koolaid_fwd.png"));
                            break;
                        case "Dark":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/koolaid_noods.png"));
                            break;
                        case "Plates":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/koolaid_plates.png"));
                            break;
                        case "Time":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/koolaid_time.png"));
                            break;
                    }
                    break;
                case "Magenta":
                    switch (wallName)
                    {
                        case "Blank":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/berry_blank.png"));
                            break;
                        case "Chevs":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/berry_chevs.png"));
                            break;
                        case "Curves":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/berry_curves.png"));
                            break;
                        case "Dan":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/berry_dan.png"));
                            break;
                        case "Fast":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/berry_fast.png"));
                            break;
                        case "Fiber":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/berry_fiber.png"));
                            break;
                        case "Forward":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/berry_fwd.png"));
                            break;
                        case "Dark":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/berry_noods.png"));
                            break;
                        case "Plates":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/berry_plates.png"));
                            break;
                        case "Time":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/berry_time.png"));
                            break;
                    }
                    break;
                case "Purple":
                    switch (wallName)
                    {
                        case "Blank":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cargo_blank.png"));
                            break;
                        case "Chevs":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cargo_chevs.png"));
                            break;
                        case "Curves":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cargo_curves.png"));
                            break;
                        case "Dan":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cargo_dan.png"));
                            break;
                        case "Fast":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cargo_fast.png"));
                            break;
                        case "Fiber":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cargo_fiber.png"));
                            break;
                        case "Forward":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cargo_fwd.png"));
                            break;
                        case "Dark":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cargo_noods.png"));
                            break;
                        case "Plates":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cargo_plates.png"));
                            break;
                        case "Time":
                            Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/cargo_time.png"));
                            break;
                    }
                    break;
            }
            PreviewImage.Source = Band2.wallpaper;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            PreviewImage.Source = Band2.wallpaper;
        }
    }
}
