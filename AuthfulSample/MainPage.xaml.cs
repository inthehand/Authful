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

//using Windows.Security.Authentication.Web;
using InTheHand.Security.Authentication.Web;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AuthfulSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public const string CLIENT_ID = "placeholder";
        public const string SCOPE = "scope";
        public static readonly Uri redirect = new Uri("https://redirect");
            
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            var res = await WebAuthenticationBroker.AuthenticateAsync(WebAuthenticationOptions.None, new Uri($"https://github.com/login/oauth/authorize?client_id={CLIENT_ID}&redirect_uri={Uri.EscapeUriString(redirect.ToString())}&scope={SCOPE}"), redirect);
        }
    }
}
