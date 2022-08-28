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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Microsoft_Band_Simulator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>


    public sealed partial class Band2 : Page
    {
        public Band2()
        {
            this.InitializeComponent();
        }

        // Public variables defined by Device Settings
        public static Color devtheme;
        public static int battery;

        private void ScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            Tile1.Fill = new SolidColorBrush(devtheme);
            Tile2.Fill = new SolidColorBrush(devtheme);
            Tile3.Fill = new SolidColorBrush(devtheme);
            Tile4.Fill = new SolidColorBrush(devtheme);
            batteryPercent.Value = battery;
            // Obsolete method, but is used in MSDocs. Okay to use here.
            #pragma warning disable CS0618 // Type or member is obsolete
            Band2view.ScrollToHorizontalOffset(offset: 45);
            #pragma warning restore CS0618 // Type or member is obsolete
        }

        private void Band2view_ViewChanging(object sender, ScrollViewerViewChangingEventArgs e)
        {
            // Removed
        }

        private async void Band2view_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
            if (e.IsIntermediate)
            {
                // Do nothing, wait for pause on the left side
            }
            else
            {
                var scrollViewer = (ScrollViewer)sender;
                if (scrollViewer.HorizontalOffset == scrollViewer.ScrollableHeight)
                {
                    // Obsolete method, but is used in MSDocs. Okay to use here.
                    #pragma warning disable CS0618 // Type or member is obsolete
                    System.Threading.Thread.Sleep(500);
                    Band2view.ScrollToHorizontalOffset(offset: 45);
                    #pragma warning restore CS0618 // Type or member is obsolete
                }
            }
        }
    }
}
