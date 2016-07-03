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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Sash_2._0
{
    public sealed partial class WebPageTab : UserControl
    {
        public delegate void NavigationStartingHandler(WebView sender, WebViewNavigationStartingEventArgs e);
        public event NavigationStartingHandler NavigationStarting;
        public delegate void NavigationCompletedHandler(WebView sender, WebViewNavigationCompletedEventArgs e);
        public event NavigationCompletedHandler NavigationCompleted;
        public delegate void NavigationFailedHandler(object sender, WebViewNavigationFailedEventArgs e);
        public event NavigationFailedHandler NavigationFailed;

        public WebView Browser;

        public WebPageTab()
        {
            this.InitializeComponent();
            Browser = webview;
            NavigationCompleted += WebPageTab_NavigationCompleted;
            NavigationFailed += WebPageTab_NavigationFailed;
            NavigationStarting += WebPageTab_NavigationStarting;
        }

        void WebPageTab_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs e)
        {
            
        }
        void WebPageTab_NavigationFailed(object sender, WebViewNavigationFailedEventArgs e)
        {
            
        }
        void WebPageTab_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs e)
        {
            
        }
        private void webview_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            NavigationStarting(sender, args);
        }
        private void webview_NavigationFailed(object sender, WebViewNavigationFailedEventArgs e)
        {
            NavigationFailed(sender, e);
        }
        private void webview_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            address.Text = webview.Source.OriginalString;
            NavigationCompleted(sender, args);
            webview.Focus(FocusState.Keyboard);
            webview.Focus(FocusState.Pointer);
        }
        private void goaddress_Click(object sender, EventArgs e)
        {
            string uri = address.Text;
            if (!uri.StartsWith("http://"))
                uri = "http://" + uri;
            webview.Navigate(new Uri(address.Text, UriKind.Absolute));
        }        
    }
}
