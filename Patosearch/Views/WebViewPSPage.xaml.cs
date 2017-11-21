using System;

using Patosearch.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Patosearch.Views
{
    public sealed partial class WebViewPSPage : Page
    {
        public WebViewPSViewModel ViewModel { get; } = new WebViewPSViewModel();

        public WebViewPSPage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
