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

<<<<<<< HEAD
            MainPage = new  Inscription();
=======
            MainPage = new  TabbedPageHome();
>>>>>>> 15722b80aa01d14e28b9ba63e1378ecc6a5cf2f1
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
