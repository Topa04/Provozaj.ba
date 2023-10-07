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
    public partial class B_kategorija : ContentPage
    {
        public B_kategorija()
        {
            InitializeComponent();
        }

        private async void Raskrsnice(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Raskrsnice());
        }

        private async void Teorija(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Teorija());
        }

        private async void Znakovi(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Znakovi());
        }

        private async void Probni(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new B_kategorijaProbni());
        }
    }
}