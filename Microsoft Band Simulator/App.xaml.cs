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

namespace Microsoft_Band_Simulator
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    // When the navigation stack isn't restored navigate to the first page,
                    // configuring the new page by passing required information as a navigation
                    // parameter
                    rootFrame.Navigate(typeof(MainPage), e.Arguments);
                }
                // Ensure the current window is active
                Window.Current.Activate();

                // Gets screen resoulution
                GetScreenResolutionInfo();

                // Add acrylic to TitleBar
                ExtendAcrylicIntoTitleBar();

                // Setting defaults
                Band2.devtheme = Colors.DeepSkyBlue;
                UV.devtheme = Colors.DeepSkyBlue;
                NotificationTemplate.devtheme = Colors.DeepSkyBlue;
                ClockApp.devtheme = Colors.DeepSkyBlue;
                SleepApp.devtheme = Colors.DeepSkyBlue;
                SettingApp.devtheme = Colors.DeepSkyBlue;
                Band2.battery = 100;
                Band2.wallpaper = new BitmapImage(new Uri("ms-appx:///Assets/Wallpaper/electric_time.png"));
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
            NotificationTemplate.NotifTime = DateTime.Now.ToString("hh:mm tt");
            NotificationTemplate.NotifDate = DateTime.Now.ToString("MM/dd");
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }
    }
}
