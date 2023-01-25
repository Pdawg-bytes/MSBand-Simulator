using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.WindowManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace Microsoft_Band_Simulator.Controls
{
    public sealed partial class MiniBand : Page
    {
        DispatcherTimer Timer = new DispatcherTimer();
        public static string miniTime;
        public static string miniDay;
        public static string miniDayName;
        public MiniBand()
        {
            this.InitializeComponent();
            SetupMini();
            var coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;
            Window.Current.SetTitleBar(MiniTitleBar);

            WallpaperImage.Source = Band2.wallpaper;

            Timer.Tick += Timer_Tick;
            Timer.Interval = new TimeSpan(1000);
            Timer.Start();
        }
        private async void SetupMini()
        {
            var preferences = ViewModePreferences.CreateDefault(ApplicationViewMode.CompactOverlay);
            preferences.CustomSize = new Windows.Foundation.Size(684, 256);
            bool success = await ApplicationView.GetForCurrentView().TryEnterViewModeAsync(ApplicationViewMode.CompactOverlay, preferences);
        }

        private void Timer_Tick(object sender, object e)
        {
            
            ClockTime.Text = miniTime;
            Date.Text = miniDay;
            DayName.Text = miniDayName;
        }

        private async void MiniBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null, new DrillInNavigationTransitionInfo());
            var preferences = ViewModePreferences.CreateDefault(ApplicationViewMode.Default);
            preferences.CustomSize = new Windows.Foundation.Size(1366, 768);
            bool success = await ApplicationView.GetForCurrentView().TryEnterViewModeAsync(ApplicationViewMode.Default, preferences);
        }
    }
}
