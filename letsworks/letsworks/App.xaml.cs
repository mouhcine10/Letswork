using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using letsworks.Views;

namespace letsworks
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Lancer();
         //   GoogleMapsApiService.Initialize(key.GoogleMapsApiKey);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
