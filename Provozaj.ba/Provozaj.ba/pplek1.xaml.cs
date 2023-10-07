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
    public partial class pplek1 : ContentPage
    {
        List<int> brojPitanja = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};


        int t = 0;
        int n = 0;
        int brPitanja = 0;
        int i;
        int rezultat;
        int brojTacnihOdg = 0;
        String Tacanodg = "";
        public pplek1()
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
                await DisplayAlert("Završili ste lekciju 1!", "Sada se možete vratiti učenju ostalih lekcija.", "Nazad na lekcije");
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
                    pitanje.Text = "Šta sadrži poziv hitnoj medicinskoj pomoći?";
                    dug1.Text = "Tačnu lokaciju bez opisa povreda.";
                    dug2.Text = "Tačnu lokaciju, broj povrijeđenih osoba bez obzira na stepen povređivanja.";
                    dug3.Text = "Tačnu lokaciju, broj povrijeđenih osoba i vrstu povreda.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    break;

                case 2:
                    pitanje.Text = "Kada ne treba započeti oživljavanje (kardiopulmonalnu reanimaciju – KPR)?";
                    dug1.Text = "Ako postoji otvorena rana na grudnom košu.";
                    dug2.Text = "Ako je opečena površina tijela veća od 60%.";
                    dug3.Text = "Ako je sigurno prošlo više od 10 minuta od zastoja srca.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    break;

                case 3:
                    pitanje.Text = "Koji su znaci teškog iskrvarenja (hemoragijskog šoka)?";
                    dug1.Text = "Izrazito bljedilo, ubrzano i površno disanje (kratak dah), teško opipljiv i ubrzan puls, koža orošena hladnim znojem, žeđanje, opšta slabost, klonulost.";
                    dug2.Text = "Usporen puls i povišen krvni pritisak, slabost, uznemirenost.";
                    dug3.Text = "Vidi se krv na odjeći, duboko disanje, slabost.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 4:
                    pitanje.Text = "Koliko dugo se vrši oživljavanje?";
                    dug1.Text = "Do dolaska stručne pomoći.";
                    dug2.Text = "40 minuta.";
                    dug3.Text = "20 minuta.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 5:
                    pitanje.Text = "Šta je šok?";
                    dug1.Text = "Strah od posljedica nesreće.";
                    dug2.Text = "Teško stanje nastalo zbog gubitka krvi, tečnosti i jakog bola.";
                    dug3.Text = "Iznenadna stresna situacija.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 6:
                    pitanje.Text = "Koje je osnovno pravilo imobilizacije?";
                    dug1.Text = "Da se imobilizuju dva susjedna zgloba.";
                    dug2.Text = "Da se imobilizuje jedan povrijeđen zglob.";
                    dug3.Text = "Da se imobilizuju svi zglobovi.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 7:
                    pitanje.Text = "Ko pruža prvu pomoć na licu mjesta?";
                    dug1.Text = "Medicinsko osoblje koje odmah pozivamo.";
                    dug2.Text = "Stručne službe na licu mjesta.";
                    dug3.Text = "Slučajni prolaznik ili osoba koja se nađe na licu mjesta.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    break;

                case 8:
                    pitanje.Text = "Šta najviše ugrožava život unesrećenog?";
                    dug1.Text = "Udarac u glavu tupim predmetom.";
                    dug2.Text = "Prelom kičmenog stuba.";
                    dug3.Text = "Prestanak disanja, besvjesno stanje i jako krvarenje.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    break;

                case 9:
                    pitanje.Text = "Šta je imobilizacija?";
                    dug1.Text = "Postavljanje tijela u stanje pripravnosti i hitan transport.";
                    dug2.Text = "Postavljanje povrijeđenog dijela tijela u nepokretan, stabilan položaj, van funkcije u određenom periodu.";
                    dug3.Text = "Postavljanje povrijeđenog na stomak i hitan transport.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 10:
                    pitanje.Text = "Šta nije prvi red hitnosti?";
                    dug1.Text = "Povreda kičme.";
                    dug2.Text = "Povreda glave praćena besvjesnim stanjem.";
                    dug3.Text = "Stanje praćeno gušenjem.";
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
                dug1.BackgroundColor = Color.Transparent;
                dug1.BorderColor = Color.White;
                dug1.TextColor = Color.White;
                dug2.BackgroundColor = Color.Transparent;
                dug2.BorderColor = Color.White;
                dug2.TextColor = Color.White;
                dug3.BackgroundColor = Color.Transparent;
                dug3.BorderColor = Color.White;
                dug3.TextColor = Color.White;
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
                dug1.BackgroundColor = Color.Transparent;
                dug1.BorderColor = Color.White;
                dug1.TextColor = Color.White;
                dug2.BackgroundColor = Color.Transparent;
                dug2.BorderColor = Color.White;
                dug2.TextColor = Color.White;
                dug3.BackgroundColor = Color.Transparent;
                dug3.BorderColor = Color.White;
                dug3.TextColor = Color.White;

            }
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