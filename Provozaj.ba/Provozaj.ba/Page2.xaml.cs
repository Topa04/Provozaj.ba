using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace Provozaj.ba
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            
        }

        private async void Prva_pomoc(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Prva_pomoc());
        }

        private async void B_kategorija(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new B_kategorija());
        }
    }
}
