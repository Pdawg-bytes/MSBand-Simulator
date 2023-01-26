using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Core;
using Windows.ApplicationModel.VoiceCommands;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using System.Timers;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft_Band_Simulator.SettingControls;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Graphics.Display;
using System.Security.Cryptography.X509Certificates;
using Microsoft_Band_Simulator.Controls;

namespace Microsoft_Band_Simulator
{
    sealed partial class App : Application
    {

        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame == null)
            {
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {

                }
                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    rootFrame.Navigate(typeof(MainPage), e.Arguments);
                }
                Window.Current.Activate();

                GetScreenResolutionInfo();
                GetAppArch();
                ExtendAcrylicIntoTitleBar();
                Band2.devtheme = Colors.DeepSkyBlue;
                UV.devtheme = Colors.DeepSkyBlue;
                NotificationTemplate.devtheme = Colors.DeepSkyBlue;
                ClockApp.devtheme = Colors.DeepSkyBlue;
                SleepApp.devtheme = Colors.DeepSkyBlue;
                SettingApp.devtheme = Colors.DeepSkyBlue;
                HealthUI.devtheme = Colors.DeepSkyBlue;
                Band2.battery = 100;
                MainPage.batcompare = 100;
                Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/electric_time.png"));
                Band2.HRIcon = new BitmapImage(new Uri("ms-appx:///Assets/Icons/heart_dark.png"));
                Band2.IsBTEnabled = false;
                Setting5.IsToggleOnS5 = false;
                HealthUI.HRVal = 75;
                HealthUI.StepCount = 0;
                HealthUI.FlightCount = 0;
                HealthUI.MileCount = 0.00;
                HealthUI.CalCount = 0;
                DeviceSettings.HRSliderEnabled = false;
                LowBattery.devtheme = Colors.DeepSkyBlue;
                DeviceSettings.BatSliderCache = 100;
                DeviceSettings.NameCache = "Band 2";
                DeviceSettings.HrSliderCache = 75;
                Setting1.devtheme = Colors.DeepSkyBlue;
                Setting2.devtheme = Colors.DeepSkyBlue;
                Setting3.devtheme = Colors.DeepSkyBlue;
                Setting4.devtheme = Colors.DeepSkyBlue;
                Setting5.devtheme = Colors.DeepSkyBlue;
                Setting6.devtheme = Colors.DeepSkyBlue;
                Setting6.sysname = Environment.MachineName;
                Setting6.bandname = "Band 2";
                Setting7.devtheme = Colors.DeepSkyBlue;

                // Init clock service
                DispatcherTimer Timer = new DispatcherTimer();
                Timer.Tick += DTW_Tick;
                Timer.Interval = new TimeSpan(1000);
                Timer.Start();

            }
        }


        // Extend Acrylic Into Titlebar Function
        private void ExtendAcrylicIntoTitleBar()
        {
            // Extends contentarea into titlebar and hides the old bar
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
        }

        private void GetAppArch()
        {
            string packagearch = Package.Current.Id.Architecture.ToString();
            if (Package.Current.Id.Architecture == Windows.System.ProcessorArchitecture.X64)
            {
                AboutDialog.AppArchDialog = "App Architecture: x64";
            }
            else if (Package.Current.Id.Architecture == Windows.System.ProcessorArchitecture.X86)
            {
                AboutDialog.AppArchDialog = "App Architecture: x86";
            }
            else if (Package.Current.Id.Architecture == Windows.System.ProcessorArchitecture.Arm64)
            {
                AboutDialog.AppArchDialog = "App Architecture: ARM64";
            }
            else if (Package.Current.Id.Architecture == Windows.System.ProcessorArchitecture.Arm)
            {
                AboutDialog.AppArchDialog = "App Architecture: ARM32";
            }
            else
            {
                AboutDialog.AppArchDialog = "Unknown";
            }
        }

        // Get screen resoultion
        public static Size GetScreenResolutionInfo()
        {
            var applicationView = ApplicationView.GetForCurrentView();
            var displayInformation = DisplayInformation.GetForCurrentView();
            var bounds = applicationView.VisibleBounds;
            var size = new Size(bounds.Width, bounds.Height);
            if (bounds.Width < 1366)
            {
                MainPage.ResTeachOpen = true;
            }
            else
            {
                MainPage.ResTeachOpen = false;
            }
            if (bounds.Height < 700)
            {
                MainPage.ResTeachOpen = true;
            }
            else
            {
                MainPage.ResTeachOpen = false;
            }
            return size;
        }

        private void DTW_Tick(object sender, object e)
        {
            Band2.time = DateTime.Now.ToString("hh:mm");
            Band2.day = DateTime.Today.Day.ToString("00");
            Band2.dayname = DateTime.Now.ToString("ddd");
            MiniBand.miniTime = DateTime.Now.ToString("hh:mm");
            MiniBand.miniDay = DateTime.Today.Day.ToString("00");
            MiniBand.miniDayName = DateTime.Now.ToString("ddd");
            NotificationTemplate.NotifTime = DateTime.Now.ToString("hh:mm tt");
            NotificationTemplate.NotifDate = DateTime.Now.ToString("MM/dd");
        }

        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            deferral.Complete();
        }
    }
}
