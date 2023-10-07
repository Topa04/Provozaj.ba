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
    public partial class raslek2 : ContentPage
    {
        List<int> brojPitanja = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };

        int t = 0;
        int n = 0;
        int brPitanja = 0;
        int i;
        int rezultat;
        int brojTacnihOdg = 0;
        String Tacanodg = "";
        public raslek2()
        {
            InitializeComponent();
            StartKviz();
            slijedecePitanje();
        }
        private void StartKviz()
        {
            var slucajna = brojPitanja.OrderBy(a => Guid.NewGuid()).ToList();
            brojPitanja = slucajna;

        }

        private void Restart()
        {
            rezultat = 0;
            brPitanja = -1;
            i = 0;
            t = 0;
            n = 0;
            StartKviz();
        }

        private async void slijedecePitanje()
        {
            t = 0;
            n = 0;
            BrPit.Text = (brPitanja + 1).ToString() + "/" + brojPitanja.Count();
            if (brPitanja < brojPitanja.Count)
            {
                i = brojPitanja[brPitanja];
            }
            else
            {
                await DisplayAlert("Završili ste lekciju 2!", "Sada se možete vratiti učenju ostalih lekcija.", "Nazad na lekcije");
                Restart();
                await Navigation.PopAsync();
            }

            foreach (var x in aplikacija.Children.OfType<Button>())
            {
                x.TabIndex = 0;
            }

            switch (i)
            {
                case 1:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "2 – 1 – 3";
                    dug2.Text = "1 – 3 – 2";
                    dug3.Text = "3 – 2 – 1";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    slikapit.Source = "r23";
                    break;

                case 2:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "3 - 2 - 1";
                    dug2.Text = "1 - 2 - 3";
                    dug3.Text = "1 - 3 - 2";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    slikapit.Source = "r24";
                    break;

                case 3:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "1 – 2 – 3";
                    dug2.Text = "2 – 1 – 3";
                    dug3.Text = "3 – 1 – 2";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    slikapit.Source = "r25";
                    break;

                case 4:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "2 – 1 – 3";
                    dug2.Text = "3 – 2 – 1";
                    dug3.Text = "1 – 3 – 2";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    slikapit.Source = "r26";
                    break;

                case 5:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "1 – 2 – 3";
                    dug2.Text = "2 – 1 – 3";
                    dug3.Text = "3 – 1 – 2";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    slikapit.Source = "r27";
                    break;

                case 6:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "3 – 2 – 1";
                    dug2.Text = "2 – 1 – 3";
                    dug3.Text = "1 – 3 – 2";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    slikapit.Source = "r28";
                    break;

                case 7:
                    pitanje.Text = "Kako u saobraćajnoj situaciji kao na slici mora postupiti vozač vozila broj 2?";
                    dug1.Text = "Propustiti vozilo broj 1;";
                    dug2.Text = "Proći prije vozila broj 1.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r29";
                    break;

                case 8:
                    pitanje.Text = "Kako u saobraćajnoj situaciji kao na slici mora postupiti vozač vozila broj 2?";
                    dug1.Text = "Proći prije vozila broj 1;";
                    dug2.Text = "propustiti vozilo broj 1.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r30";
                    break;

                case 9:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "2 – 1 – 3";
                    dug2.Text = "3 – 1 – 2";
                    dug3.Text = "3 – 2 – 1";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r31";
                    break;

                case 10:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "1 – 2 – 3 – 4";
                    dug2.Text = "4 – 1 – 2 – 3";
                    dug3.Text = "2 – 3 – 4 – 1";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r32";
                    break;

                case 11:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "3 – 1 – 2";
                    dug2.Text = "2 – 1 – 3";
                    dug3.Text = "1 – 2 – 3";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r33";
                    break;

                case 12:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "3 – 2 – 1";
                    dug2.Text = "1 – 2 – 3";
                    dug3.Text = "2 – 1 – 3";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r34";
                    break;

                case 13:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "1 – 3 – 2";
                    dug2.Text = "2 – 3 – 1";
                    dug3.Text = "3 – 2 – 1";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r35";
                    break;

                case 14:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici";
                    dug1.Text = "2 – 3 – 1";
                    dug2.Text = "3 – 2 – 1";
                    dug3.Text = "3 – 1 – 2";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r36";
                    break;

                case 15:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "3 – 2 – 1";
                    dug2.Text = "1 – 2 – 3";
                    dug3.Text = "2 – 1 – 3";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r37";
                    break;

                case 16:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "3 – 2 – 1";
                    dug2.Text = "2 – 3 – 1";
                    dug3.Text = "1 – 2 – 3";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r38";
                    break;

                case 17:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "2 – 3 – 1";
                    dug2.Text = "1 – 3 – 2";
                    dug3.Text = "1 – 2 – 3";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r39";
                    break;

                case 18:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "3 – 2 – 1;";
                    dug2.Text = "2 – 1 – 3";
                    dug3.Text = "1 – 2 – 3";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r40";
                    break;

                case 19:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "2 – 3 – 1";
                    dug2.Text = "1 – 3 – 2";
                    dug3.Text = "2 – 1 – 3";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r41";
                    break;

                case 20:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "3 – 2 – 1";
                    dug2.Text = "3 – 1 – 2";
                    dug3.Text = "1 – 2 – 3";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    Tacanodg = dug3.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r42";
                    break;

                case 21:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "1 – 2 – 3";
                    dug2.Text = "3 – 1 – 2";
                    dug3.Text = "2 – 1 – 3";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    Tacanodg = dug3.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r43";
                    break;

                case 22:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "3 – 2 – 1";
                    dug2.Text = "2 – 1 – 3";
                    dug3.Text = "1 – 2 – 3";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r44";
                    break;

            }
        }

        
        private void klik(object sender, EventArgs e)
        {
            Button dugme = sender as Button;



            if (dugme.IsEnabled == true && dugme.BackgroundColor == Color.FromHex("#D3DDE7"))
            {
                dugme.BackgroundColor = Color.Transparent;
                dugme.BorderColor = Color.White;
                dugme.TextColor = Color.White;
                if (dugme.TabIndex.ToString() == "1")
                {
                    t--;
                }
                else
                {
                    n--;
                }
            }
            else if (dugme.IsEnabled == true)
            {
                dugme.BackgroundColor = Color.FromHex("#D3DDE7");
                dugme.BorderColor = Color.FromHex("#8D97A1");
                dugme.TextColor = Color.FromHex("#0d7c9b");
                if (dugme.TabIndex.ToString() == "1")
                {
                    t++;

                }
                else
                {
                    n++;
                }
            }
            else
            {
                dugme.BackgroundColor = Color.Transparent;
                dugme.BorderColor = Color.White;
                dugme.TextColor = Color.White;
            }

        }

        private async void Provjera(object sender, EventArgs e)
        {
            if (t == brojTacnihOdg && n == 0)
            {
                rezultat++;
                if (brojTacnihOdg == 2)
                {
                    await DisplayAlert("Tačno!", "Uneseni odgovori su tačni.", "Nastavi");
                }
                else
                {
                    await DisplayAlert("Tačno!", "Uneseni odgovor je tačan.", "Nastavi");
                }
            }
            else
            {
                if (brojTacnihOdg == 2)
                {
                    await DisplayAlert("Netačno!", "Uneseni odgovori nisu tačani. Tačni odgovori su '" + Tacanodg.ToString() + "'.", "Nastavi");
                }
                else
                {
                    await DisplayAlert("Netačno!", "Uneseni odgovor nije tačan. Tačan odgovor je '" + Tacanodg.ToString() + "'.", "Nastavi");
                }
            }
            dug1.BackgroundColor = Color.Transparent;
            dug1.BorderColor = Color.White;
            dug1.TextColor = Color.White;
            dug2.BackgroundColor = Color.Transparent;
            dug2.BorderColor = Color.White;
            dug2.TextColor = Color.White;
            dug3.BackgroundColor = Color.Transparent;
            dug3.BorderColor = Color.White;
            dug3.TextColor = Color.White;
            if (brPitanja < 0)
            {
                brPitanja = 0;
            }
            else
            {
                brPitanja++;
            }
            slijedecePitanje();
        }
    }
}