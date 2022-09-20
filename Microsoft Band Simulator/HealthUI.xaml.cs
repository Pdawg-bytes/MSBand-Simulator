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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Microsoft_Band_Simulator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HealthUI : Page
    {
        public HealthUI()
        {
            this.InitializeComponent();
        }

        public static Color devtheme;
        public static bool HRState;
        public static int HRVal;
        public static double StepCount;
        public static double MileCount;
        public static double CalCount;

        private void Healthview_Loaded(object sender, RoutedEventArgs e)
        {
            HealthUISidebar.Fill = new SolidColorBrush(devtheme);
            if (HRState == true)
            {
                HROnIcon.Visibility = Visibility.Visible;
                HRValueText.Visibility = Visibility.Visible;
                HRValueText.Text = HRVal.ToString();
                HRLock.Visibility = Visibility.Visible;
                HROffDesc.Visibility = Visibility.Collapsed;
                HROffIcon.Visibility = Visibility.Collapsed;
                HROffLabel.Visibility = Visibility.Collapsed;
            }
            else
            {
                HROnIcon.Visibility = Visibility.Collapsed;
                HRValueText.Visibility = Visibility.Collapsed;
                HRLock.Visibility = Visibility.Collapsed;
                HROffDesc.Visibility = Visibility.Visible;
                HROffIcon.Visibility = Visibility.Visible;
                HROffLabel.Visibility = Visibility.Visible;
            }
            StepsCount.Text = StepCount.ToString();
            MilesCount.Text = MileCount.ToString();
            CaloriesCount.Text = CalCount.ToString();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Band2), null, new DrillInNavigationTransitionInfo());
        }
    }
}
