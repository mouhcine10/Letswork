using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace letsworks.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lancer : ContentPage
    {
        public Lancer()
        {
          
            InitializeComponent();

            
        }
        void llogin(object sender, EventArgs arg)
        {
            Navigation.PushModalAsync(new NavigationPage(new Login()));

        }

        public void Inscription(object sender, EventArgs args)
        {

            Navigation.PushModalAsync(new NavigationPage(new MapView()));
        }

    }
}