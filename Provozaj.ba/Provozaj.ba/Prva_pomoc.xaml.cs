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
    public partial class Prva_pomoc : ContentPage
    {
        public Prva_pomoc()
        {
            InitializeComponent();
        }

        private async void ppUcenje(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Prva_pomoc_lekcije());
        }

        private async void ppProbni(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ppprobni());
        }

    }
}