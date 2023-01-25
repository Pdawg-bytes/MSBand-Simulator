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
    public sealed partial class NotificationTemplate : Page
    {
        public NotificationTemplate()
        {
            this.InitializeComponent();
        }

        public static Color devtheme;
        public static string NotifTitle;
        public static string NotifContent;
        public static string NotifTime;
        public static string NotifDate;

        private void Notifview_Loaded(object sender, RoutedEventArgs e)
        {
            Notifbar.Fill = new SolidColorBrush(devtheme);
            NotificationLabel.Foreground = new SolidColorBrush(devtheme);
            NotificationContent.Text = NotifContent;
            NotificationLabel.Text = NotifTitle;
            NotificationDate.Text = (NotifDate + " - " + NotifTime);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Band2), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromLeft });
        }
    }
}
