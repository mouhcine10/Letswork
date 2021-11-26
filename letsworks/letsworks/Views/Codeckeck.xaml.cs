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
    public partial class Codeckeck : ContentPage
    {
        public Codeckeck()
        {
            InitializeComponent();
        }

        void Validercode(object sender, EventArgs arg)
        {
            Navigation.PushModalAsync(new NavigationPage(new Inscription()));

        }
    }
}