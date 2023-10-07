using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Provozaj.ba
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Prva_pomoc_lekcije : ContentPage
    {
        public Prva_pomoc_lekcije()
        {
            InitializeComponent();
        }

        private async void Lekcija1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pplek1());
        }

        private async void Lekcija2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pplek2());
        }

        private async void Lekcija3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pplek3());
        }
    }
}