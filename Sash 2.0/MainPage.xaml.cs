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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Sash_2._0
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void go_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {

        }

        private void WebPageTab_NavigationCompleted_1(WebView sender, WebViewNavigationCompletedEventArgs e)
        {
            string title = sender.DocumentTitle;
            home.Header = (title.Trim().Length == 0)?"";
        }

        private void WebPageTab_NavigationFailed(object sender, WebViewNavigationFailedEventArgs e)
        {
            home.Header = ((WebView)sender).DocumentTitle;
        }

        private void WebPageTab_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs e)
        {
            home.Header = sender.DocumentTitle;
        }
    }
}
