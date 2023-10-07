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
    public partial class raslek3 : ContentPage
    {
        List<int> brojPitanja = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };

        int t = 0;
        int n = 0;
        int brPitanja = 0;
        int i;
        int rezultat;
        int brojTacnihOdg = 0;
        String Tacanodg = "";
        public raslek3()
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
                await DisplayAlert("Završili ste lekciju 3!", "Sada se možete vratiti učenju ostalih lekcija.", "Nazad na lekcije");
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
                    dug1.Text = "3 – 2 – 1";
                    dug2.Text = "2 – 1 – 3";
                    dug3.Text = "1 – 3 – 2";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r45";
                    break;

                case 2:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "3 – 1 – 2";
                    dug2.Text = "2 – 1 – 3";
                    dug3.Text = "1 – 3 – 2";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r46";
                    break;

                case 3:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "2 – 1 – 3";
                    dug2.Text = "3 – 2 – 1";
                    dug3.Text = "1 – 3 – 2";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r47";
                    break;

                case 4:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "1 – 2 – 3";
                    dug2.Text = "2 – 3 – 1";
                    dug3.Text = "3 – 2 – 1";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r48";
                    break;

                case 5:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "2 – 1 – 3 – 4";
                    dug2.Text = "1 – 2 – 3 – 4";
                    dug3.Text = "1 – 2 – 4 – 3";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r49";
                    break;

                case 6:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "1 – 3 – 2";
                    dug2.Text = "3 – 2 – 1";
                    dug3.Text = "2 – 3 – 1";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    Tacanodg = dug3.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r50";
                    break;

                case 7:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "2 – 3 – 1";
                    dug2.Text = "2 – 1 – 3";
                    dug3.Text = "3 – 1 – 2";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r51";
                    break;

                case 8:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "1 – 3 – 2";
                    dug2.Text = "3 pa 2 i 1 istovremeno";
                    dug3.Text = "2 i 1 istovremeno pa 3";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r52";
                    break;

                case 9:
                    pitanje.Text = "Da li je u saobraćajnoj situaciji kao na slici dozvoljeno izvršiti radnju polukružnog okretanja vozilom kojim upravljate?";
                    dug1.Text = "Da.";
                    dug2.Text = "Ne.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r53";
                    break;

                case 10:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "1 – 3 – 2";
                    dug2.Text = "1 – 2 – 3";
                    dug3.Text = "3 – 1 – 2";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r54";
                    break;

                case 11:
                    pitanje.Text = "Redoslijed prolaska na raskrsnici je:";
                    dug1.Text = "1 – 3 – 2";
                    dug2.Text = "3 – 1 – 2";
                    dug3.Text = "2 – 3 – 1";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r55";
                    break;

                case 12:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "4 – 1 – 2 – 3";
                    dug2.Text = "2 – 3 – 4 – 1";
                    dug3.Text = "2 – 3 – 1 – 4";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r56";
                    break;

                case 13:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "3 – 2 – 1";
                    dug2.Text = "3 – 1 – 2";
                    dug3.Text = "2 – 3 – 1";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r57";
                    break;

                case 14:
                    pitanje.Text = "Kako  ćete postupiti na raskrsnici na kojoj je saobraćaj regulisan svjetlosnom saobraćajnom signalizacijom kao na slici?";
                    dug1.Text = "Obavezno zaustaviti vozilo jer se uključujem sa sporednog puta.";
                    dug2.Text = "Obavezno zaustaviti vozilo zbog znaka „STOP“.";
                    dug3.Text = "Nastaviti kretanje vozilom.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    Tacanodg = dug3.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r58";
                    break;

                case 15:
                    pitanje.Text = "Kako ćete postupiti na raskrsnici u saobraćajnoj situaciji kao na slici?";
                    dug1.Text = "Nastaviti kretanje vozilom jer nema niko sa desne strane.";
                    dug2.Text = "Proći drugi jer ste žutom vozilu sa desne strane.";
                    dug3.Text = "Zaustaviti se i propustiti oba vozila.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    Tacanodg = dug3.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r59";
                    break;

                case 16:
                    pitanje.Text = "Kako ćete postupiti na raskrsnici u saobraćajnoj situaciji kao na slici? (2 tačna odgovora)";
                    dug1.Text = "Propustiti crveno vozilo.";
                    dug2.Text = "Zaustaviti se i propustiti oba vozila.";
                    dug3.Text = "Proći kroz raskrsnicu prije žutog vozila.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    dug3.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug1.Text + "' i '" + dug3.Text;
                    slikapit.Source = "r60";
                    break;

                case 17:
                    pitanje.Text = "Kako  ćete postupiti u saobraćajnoj situaciji kao na slici ako upravljate plavim automobilom?";
                    dug1.Text = "Proći prvi jer sam sa desne strane.";
                    dug2.Text = "Proći prvi jer skrećem udesno.";
                    dug3.Text = "Zaustaviti se i propustiti crveno vozilo.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    Tacanodg = dug3.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r61";
                    break;

                case 18:
                    pitanje.Text = "Kako  ćete postupiti u saobraćajnoj situaciji kao na slici ako imate namjeru proći raskrsnicu?";
                    dug1.Text = "Obavezno se zaustaviti, bez obzira ima li vozila sa lijeve strane u raskrsnici.";
                    dug2.Text = "Nastaviti kretanje bez zaustavljanja jer me vozači vozila u raskrsnici moraju propustiti.";
                    dug3.Text = "Zaustaviti se po potrebi, radi propuštanja vozila koja su već u raskrsnici, a potom proći kroz raskrsnicu.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    Tacanodg = dug3.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r62";
                    break;

                case 19:
                    pitanje.Text = "Kako  ćete postupiti u saobraćajnoj situaciji kao na slici prilikom dolaska na raskrsnicu? (2 tačna odgovora)";
                    dug1.Text = "Nastaviti kretanje jer ne mijenjam smjer kretanja vozila.";
                    dug2.Text = "Propustiti motocikl.";
                    dug3.Text = "Proći prije vozila koje dolazi iz suprotnog smjera.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    dug3.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug2.Text + "' i '" + dug3.Text;
                    slikapit.Source = "r63";
                    break;

                case 20:
                    pitanje.Text = "Kako trebate postupiti u saobraćajnoj situaciji kao na slici prilikom dolaska na raskrsnicu?";
                    dug1.Text = "Proći prvi kroz raskrsnicu.";
                    dug2.Text = "Proći drugi kroz raskrsnicu, nakon propuštanja bijelog vozila.";
                    dug3.Text = "Proći posljednji kroz raskrsnicu.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r64";
                    break;

                case 21:
                    pitanje.Text = "Kako trebate postupiti u saobraćajnoj situaciji kao na slici prilikom dolaska na raskrsnicu?";
                    dug1.Text = "Zaustaviti se i propustiti oba vozila.";
                    dug2.Text = "Proći prvi kroz raskrsnicu jer sam cvenom vozilu sa desne strane.";
                    dug3.Text = "Propustiti crveno vozilo, a zatim proći kroz raskrsnicu istovremeno sa autobusom.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    Tacanodg = dug3.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r65";
                    break;

                case 22:
                    pitanje.Text = "Kako trebate postupiti u saobraćajnoj situaciji kao na slici? (2 tačna odgovora)";
                    dug1.Text = "Nastaviti kretanje vozilom ulijevo, nakon propuštanja vozila koja dolaze sa desne strane.";
                    dug2.Text = "Obavezno se zaustaviti.";
                    dug3.Text = "Nakon što se na semaforu upali zeleno svjetlo, nastaviti kretanje vozilom ulijevo.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    dug3.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug2.Text + "' i '" + dug3.Text;
                    slikapit.Source = "r66";
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