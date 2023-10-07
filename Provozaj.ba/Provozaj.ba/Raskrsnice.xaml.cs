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
    public partial class Raskrsnice : ContentPage
    {
        public Raskrsnice()
        {
            InitializeComponent();
         
        }

        private async void lekcija1(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new raslek1());
            
            
        }

        private async void lekcija2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new raslek2());
        }

        private async void lekcija3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new raslek3());
        }
    }
}