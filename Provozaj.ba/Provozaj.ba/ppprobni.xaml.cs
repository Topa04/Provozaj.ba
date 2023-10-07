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
    public partial class ppprobni : ContentPage
    {
        List<int> brojPitanja = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        int t = 0;
        int n = 0;
        int brPitanja = 0;
        int i;
        int rezultat;
        int brojTacnihOdg = 0;
        String Tacanodg = "";
        public ppprobni()
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
                if (rezultat >= 8)
                {
                    await DisplayAlert("Završili ste probni test", "Čestitamo! Imali ste " + rezultat + " tačnih odgovora.", "Nazad na Prvu pomoć");
                    Restart();
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Završili ste probni test", "Nažalost, imali ste samo " + rezultat + " tačnih odgovora.", "Nazad na Prvu pomoć");
                    Restart();
                    await Navigation.PopAsync();
                }
            }

            foreach (var x in aplikacija.Children.OfType<Button>())
            {
                x.TabIndex = 0;
            }

            switch (i)
            {
                case 1:
                    pitanje.Text = "Kod oživljavanja (KPR) odnos disanja i spoljne masaže srca je:";
                    dug1.Text = "2 upuhivanja i 15 masaža srca, tj. odnos 2:15.";
                    dug2.Text = "5 upuhivanja i 5 masaža srca, tj. odnos 1:1.";
                    dug3.Text = "30 masaža srca i 2 upuhivanja, tj. odnos 30:2.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    break;

                case 2:
                    pitanje.Text = "Koji su neki od znakova predoziranja narkoticima?";
                    dug1.Text = "Proširene zjenice, besvjesno stanje.";
                    dug2.Text = "Pojačani refleksi i koncentracija.";
                    dug3.Text = "Koža koja se ljušti.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 3:
                    pitanje.Text = "Koji su znaci unutrašnjeg krvarenja?";
                    dug1.Text = "Usporeno disanje.";
                    dug2.Text = "Boja kože lica je crvena a disanje usporeno.";
                    dug3.Text = "Blijeda koža orošena znojem,usne i jezik suvi, ubrzano disanje, malaksalost i jak osjećaj žeđi.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    break;

                case 4:
                    pitanje.Text = "Šta se podrazumijeva pod opekotinama prvog stepena?";
                    dug1.Text = "Opečena je koža, potkožno masno tkivo i mišići u predjelu opekotine.";
                    dug2.Text = "Zahvaćeni su površinski dijelovi kože, koža je crvena, bez mjehura, lako otečena, a postaje vrlo bolna nakon nekoliko časova.";
                    dug3.Text = "Zahvaćeni su dublji slojevi tkiva i kosti.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 5:
                    pitanje.Text = "Šta učiniti ukoliko situacija nije bezbjedna i ne možete pristupiti mjestu nesreće?";
                    dug1.Text = "Hitno doći do povrijeđene osobe.";
                    dug2.Text = "Sanirati najhitnija stanja.";
                    dug3.Text = "Pozvati hitnu medicinsku pomoć i sačekati dolazak nadležnih.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    break;

                case 6:
                    pitanje.Text = "Koji je postupak pružanja prve pomoći kod otvorenog preloma kosti bez krvarenja?";
                    dug1.Text = "Imobilizacija i hitan transport.";
                    dug2.Text = "Prekrivanje rane sterilnom gazom, istezanje, hitan transport.";
                    dug3.Text = "Prekrivanje rane sterilnom gazom, imobilizacija, transport nije hitan.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 7:
                    pitanje.Text = "Šta prvo treba učiniti kod udara električne struje?";
                    dug1.Text = "Povrijeđenog zakopati u zemlju da bi zemlja izvukla struju.";
                    dug2.Text = "Prekinuti strujni krug, izvući utikač, osigurač, isključiti sklopku, izolirajućim predmetom skloniti izvor električnog napajanja.";
                    dug3.Text = "Odmah započeti sa oživljavanjem.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 8:
                    pitanje.Text = "Šta sadrži poziv hitnoj medicinskoj pomoći?";
                    dug1.Text = "Tačnu lokaciju bez opisa povreda.";
                    dug2.Text = "Tačnu lokaciju, broj povrijeđenih osoba bez obzira na stepen povređivanja.";
                    dug3.Text = "Tačnu lokaciju, broj povrijeđenih osoba i vrstu povreda.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    break;

                case 9:
                    pitanje.Text = "Koliko dugo se vrši oživljavanje?";
                    dug1.Text = "Do dolaska stručne pomoći.";
                    dug2.Text = "40 minuta.";
                    dug3.Text = "20 minuta.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 10:
                    pitanje.Text = "Koje je osnovno pravilo imobilizacije?";
                    dug1.Text = "Da se imobilizuju dva susjedna zgloba.";
                    dug2.Text = "Da se imobilizuje jedan povrijeđen zglob.";
                    dug3.Text = "Da se imobilizuju svi zglobovi.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;



            }
        }

        
        private void klik(object sender, EventArgs e)
        {
            Button dugme = sender as Button;


            if (dugme.IsEnabled == true && dugme.BackgroundColor == Color.White)
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
                dugme.BackgroundColor = Color.White;
                dugme.BorderColor = Color.LightGray;
                dugme.TextColor = Color.Red;
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
        private void Provjera(object sender, EventArgs e)
        {
            if (t == brojTacnihOdg && n == 0)
            {
                rezultat++;
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