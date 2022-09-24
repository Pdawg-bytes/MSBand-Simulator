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
    public sealed partial class LowBattery : Page
    {
        public LowBattery()
        {
            this.InitializeComponent();
        }

        public static Color devtheme;

        private void LowBatteryview_Loaded(object sender, RoutedEventArgs e)
        {
            // Obsolete method, but is used in MSDocs. Okay to use here.
            #pragma warning disable CS0618 // Type or member is obsolete
            LowBatteryView.ScrollToHorizontalOffset(offset: 200);
            #pragma warning restore CS0618 // Type or member is obsolete
            BatLowLabel.Foreground = new SolidColorBrush(devtheme);
        }

        private void DismissButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Band2), null, new DrillInNavigationTransitionInfo());
        }
    }
}
