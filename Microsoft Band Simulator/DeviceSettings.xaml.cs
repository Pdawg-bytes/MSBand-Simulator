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
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

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
            Color theme;
            switch (themeName)
            {
                case "Microsoft Blue":
                default:
                    theme = Colors.DeepSkyBlue;
                    break;
                case "Dark Cyan":
                    theme = Colors.DarkCyan;
                    break;
                case "Teal":
                    theme = Colors.Teal;
                    break;
                case "Light Green":
                    theme = Colors.LimeGreen;
                    break;
                case "Yellow Green":
                    theme = Colors.YellowGreen;
                    break;
                case "Yellow":
                    theme = Colors.Yellow;
                    break;
                case "Orange":
                    theme = Colors.Orange;
                    break;
                case "Red":
                    theme = Colors.Red;
                    break;
                case "Hot Pink":
                    theme = Colors.HotPink;
                    break;
                case "Magenta":
                    theme = Colors.DarkMagenta;
                    break;
                case "Purple":
                    theme = Colors.BlueViolet;
                    break;

            }
            ColorTheme.Fill = new SolidColorBrush(theme);
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
    }
}
