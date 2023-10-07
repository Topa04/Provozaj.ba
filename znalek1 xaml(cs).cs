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
    public partial class znalek1 : ContentPage
    {
        List<int> brojPitanja = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        int t = 0;
        int n = 0;
        int brPitanja = 0;
        int i;
        int rezultat;
        int brojTacnihOdg = 0;
        String Tacanodg = "";
        public znalek1()
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
            dug3.TextTransform = 0;
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
                    pitanje.Text = "Šta treba izbjegavati nailaskom na ovaj saobraćajni znak?(2 tačna odgovora)";
                    dug1.Text = "Vožnju prilagođenu uslovima koji vladaju na kolovozu.";
                    dug2.Text = "Nagle pokrete točkom upravljača.";
                    dug3.Text = "Naglo kočenje i zaustavljanje.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    dug3.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug2.Text + "' i '" + dug3.Text;
                    slikapit.Source = "z1";
                    break;

                case 2:
                    pitanje.Text = "Kako treba postupiti nailaskom na ovaj saobraćajni znak?";
                    dug1.Text = "Pripremiti se za savladavanje više uzastopnih krivina od kojih je prva udesno.";
                    dug2.Text = "Učesnike u saobraćaju iza sebe upozoriti desnim pokazivačem pravca.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    slikapit.Source = "z2";
                    break;

                case 3:
                    pitanje.Text = "Na koju opasnost upozorava ovaj saobraćajni znak?";
                    dug1.Text = "Na blizinu dijela puta gdje je uz kolovoz neutvrđena bankina.";
                    dug2.Text = "Na blizinu dijela puta gdje je zaleđen kolovoz.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    slikapit.Source = "z3";
                    break;

                case 4:
                    pitanje.Text = "Kako ćete postupiti nailaskom na ovoj saobraćajni znak?(2 tačna odgovora)";
                    dug1.Text = "Nastaviti kretanje vozilom jer imam prvenstvo prolaza.";
                    dug2.Text = "Smanjiti brzinu kretanja vozila i po potrebi zaustaviti vozilo.";
                    dug3.Text = "Propustiti vozila iz suprotnog smjera.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    dug3.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug2.Text + "' i '" + dug3.Text;
                    slikapit.Source = "z4";
                    break;

                case 5:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je?";
                    dug1.Text = "Zabrana saobraćaja za sva motorna vozila koja vuku priključno vozilo.";
                    dug2.Text = "Zabrana saobraćaja za sva motorna vozila koja vuku laku prikolicu.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    slikapit.Source = "z5";
                    break;

                case 6:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je:";
                    dug1.Text = "Elektronska naplata putarine.";
                    dug2.Text = "Zabrana korištenja radio-aparata u vozilu.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    slikapit.Source = "z6";
                    break;

                case 7:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je:";
                    dug1.Text = "Niša za zaustavljanje vozila u slučaju opasnosti.";
                    dug2.Text = "Prostor rezervisan za zaustavljanje vozila javnog gradskog prevoza.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z7";
                    break;

                case 8:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je:";
                    dug1.Text = "Radionica za popravku gum.";
                    dug2.Text = "Mjesto gdje možete kontrolisati pritisak u gumama.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z8";
                    break;

                case 9:
                    pitanje.Text = "Kako treba postupiti nailaskom na ovaj saobraćajni znak?(2 tačna odgovora)";
                    dug1.Text = "Povećati pažnju.";
                    dug2.Text = "Pružiti pomoć povrjeđenim u saobraćajnoj nezgodi.";
                    dug3.Text = "Povećavati brzinu kretanja vozila.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    dug2.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug1.Text + "' i '" + dug2.Text;
                    slikapit.Source = "z9";
                    break;

                case 10:
                    pitanje.Text = "Koje značenje ima ovaj saobraćajni znak?";
                    dug1.Text = "Ulazak u područje u kojem postoji povećana opasnost od izbijanja nekontrolisanog požara.";
                    dug2.Text = "Ulazite u područje gdje je dozvoljeno izletnicima paljenje vatre.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z10";
                    break;

                case 11:
                    pitanje.Text = "Kako treba postupiti nailaskom na ovaj saobraćajni znak?(2 tačna odgovora)";
                    dug1.Text = "Smanjiti brzinu kretanja vozila i povećavati pažnju.";
                    dug2.Text = "Predvidjeti mogućnost nailaska na poledicu na kolovozu.";
                    dug3.Text = "Povećavati brzinu kretanja vozila.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    dug2.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug1.Text + "' i '" + dug2.Text;
                    slikapit.Source = "z11";
                    break;

                case 12:
                    pitanje.Text = "Kojim vozilima je zabranjeno kretanje putem označenim ovim saobraćajnim znakom?";
                    dug1.Text = "Biciklima.";
                    dug2.Text = "Autobusima i teretnim vozilima.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z12";
                    break;

                case 13:
                    pitanje.Text = "Kojim vozilima je dozvoljeno kretanje putem označenim ovim saobraćajnim znakom?";
                    dug1.Text = "Biciklima, mopedima i lakim motociklima.";
                    dug2.Text = "Motociklima.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z13";
                    break;

                case 14:
                    pitanje.Text = "Koje značenje ima ovaj saobraćajni znak?";
                    dug1.Text = "Zabrana saobraćaja za vozila koja prevoze opasne materije iznad određene količine.";
                    dug2.Text = "Zabrana saobraćaja za vozila koja prevoze eksploziv ili neke lako zapaljive materije.";
                    dug3.Text = "";
                    dug3.IsVisible = false;


                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z14";
                    break;

                case 15:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je?";
                    dug1.Text = "Teren uređen za kampovanje u vozilima.";
                    dug2.Text = "Zabranjeno kampovanje u vozilima.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z15";
                    break;

                case 16:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je?";
                    dug1.Text = "Blizina mjesta na kojem se nalazi autopraonica.";
                    dug2.Text = "Blizina mjesta gdje je zabranjeno pranje vozila.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z16";
                    break;

                case 17:
                    pitanje.Text = "Koje značenje ima znak koji daje ovlašteno lice na raskrsnici?";
                    dug1.Text = "Dozvoljen prolaz vozilima koja dolaze sa bočnih strana ovlaštenog lica.";
                    dug2.Text = "Obavezno zaustavljanje za sva vozila ispred raskrsnice.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z17";
                    break;

                case 18:
                    pitanje.Text = "Dvostruka isprekidana linija služi za obilježavanje:";
                    dug1.Text = "Saobraćajnih traka sa izmjenljivim smjerom kretanja na kojima je saobraćaj regulisan uređajima za davanje svjetlosnih saobraćajnih znakova.";
                    dug2.Text = "Saobraćajne trake koju mogu koristiti samo vozila s pravom prvenstva prolaza.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z18";
                    break;

                case 19:
                    pitanje.Text = "Kada će vozač koji upravlja vozilom koje prevozi opasne materije koristiti ovaj znak?";
                    dug1.Text = "Kad vrši prevoz na temperaturi ispod 0 ˚C.";
                    dug2.Text = "Kad vrši prevoz opasnih materija na povišenoj temperaturi.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z19";
                    break;

                case 20:
                    pitanje.Text = "Kako treba postupiti nailaskom na ovaj saobraćajni znak?";
                    dug1.Text = "Obavezno voziti ulijevo.";
                    dug2.Text = "Nastaviti kretanje vozilom pravom.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z20";
                    break;
            }
        }

        
        private void klik(object sender, EventArgs e)
        {
            Button dugme = sender as Button;



            if (dugme.IsEnabled == true && dugme.BackgroundColor == Color.FromHex("#803434"))
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
                dugme.BackgroundColor = Color.FromHex("#803434");
                dugme.BorderColor = Color.FromHex("#8D97A1");
                dugme.TextColor = Color.White;
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