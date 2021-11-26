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
    public partial class CheckPhone : ContentPage
    {
        public CheckPhone()
        {
            InitializeComponent();
        }
        public void Valider(object sender, EventArgs arg)
        {
            Navigation.PushModalAsync(new NavigationPage(new Codeckeck()));

        }
    }
}