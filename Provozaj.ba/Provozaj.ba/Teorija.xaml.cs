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
    public partial class Teorija : ContentPage
    {
        public Teorija()
        {
            InitializeComponent();
        }

        private async void Teorija1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new teolek1());
        }

        private async void Teorija2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new teolek2());
        }

        private async void Teorija3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new teolek3());
        }
    }
}