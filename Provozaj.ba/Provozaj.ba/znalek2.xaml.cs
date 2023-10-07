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
    public partial class znalek2 : ContentPage
    {
        List<int> brojPitanja = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        int t = 0;
        int n = 0;
        int brPitanja = 0;
        int i;
        int rezultat;
        int brojTacnihOdg = 0;
        String Tacanodg = "";
        public znalek2()
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
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je?";
                    dug1.Text = "Ukrštanje puteva istog značaja.";
                    dug2.Text = "Ukrštanje sporednih puteva pod oštrim uglom.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    slikapit.Source = "z21";
                    break;

                case 2:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je?";
                    dug1.Text = "Pokretni most.";
                    dug2.Text = "Blizina obale.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    slikapit.Source = "z22";
                    break;

                case 3:
                    pitanje.Text = "Koje značenje ima ovaj saobraćajni znak? (2 tačna odgovora)";
                    dug1.Text = "Zabrana saobraćaja u oba smjera.";
                    dug2.Text = "Zabrana saobraćaja u smjeru kretanja vozila.";
                    dug3.Text = "Da se saobraćaj odvija iz suprotnog smjera.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    dug3.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug2.Text + "' i '" + dug3.Text;
                    slikapit.Source = "z23";
                    break;

                case 4:
                    pitanje.Text = "Koje značenje ima ovaj saobraćajni znak?";
                    dug1.Text = "Produžetak puta sa prvenstvom prolaza.";
                    dug2.Text = "Završetak puta ili dijela puta sa prvenstvom prolaza.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    slikapit.Source = "24";
                    break;

                case 5:
                    pitanje.Text = "Kako ćete postupiti nailaskom na ovaj saobraćajni znak?";
                    dug1.Text = "Uz povećanu pažnju nastaviti kretanje vozilom, jer imam pravo prvenstva prolaza u odnosu na vozila koja dolaze iz suprotnog smjera.";
                    dug2.Text = "Zaustaviti vozilo i propustiti vozila iz suprotnog smjera.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    slikapit.Source = "z25";
                    break;

                case 6:
                    pitanje.Text = "Kako ćete postupiti nailaskom na ovaj saobraćajni znak?";
                    dug1.Text = "Smanjiti brzinu kretanja vozila do brzine hoda pješaka.";
                    dug2.Text = "Povećati brzinu kretanja vozila.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    slikapit.Source = "z26";
                    break;

                case 7:
                    pitanje.Text = "Kojim vozilima je dozvoljeno kretanje putem označenim ovim saobraćajnim znakom? (2 tačna odgovora)";
                    dug1.Text = "Biciklu.";
                    dug2.Text = "Putničkom vozilu, teretnom vozilu, autobusu.";
                    dug3.Text = "Motociklu.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    dug3.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug2.Text + "' i '" + dug3.Text;
                    slikapit.Source = "z27";
                    break;

                case 8:
                    pitanje.Text = "Koja vozila se obilježavaju znakom kao na slici?";
                    dug1.Text = "Vozila koja prevoze opasne materije.";
                    dug2.Text = "Spora vozila.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z28";
                    break;

                case 9:
                    pitanje.Text = "Koje značenje ima ovaj saobraćajni znak?";
                    dug1.Text = "Opasnost za koju nije predviđen poseban znak.";
                    dug2.Text = "Opasnost kad se krećemo klizavim kolovozom.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z29";
                    break;

                case 10:
                    pitanje.Text = "Kako treba postupiti nailaskom na ovaj saobraćajni znak?";
                    dug1.Text = "Pravovremeno prebaciti u niži stepen prenosa.";
                    dug2.Text = "Prebaciti u viši stepen prenosa i što više kočiti nožnom kočnicom.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z30";
                    break;

                case 11:
                    pitanje.Text = "Kako treba postupiti nailaskom na ovaj saobraćajni znak? (2 tačna odgovora)";
                    dug1.Text = "Smanjiti brzinu kretanja vozila.";
                    dug2.Text = "Povećavati pažnju i očekivati bicikliste.";
                    dug3.Text = "Povećati brzinu kretanja vozila.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    dug2.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug1.Text + "' i '" + dug2.Text;
                    slikapit.Source = "z31";
                    break;

                case 12:
                    pitanje.Text = "Kojim vozilima nije dozvoljeno kretanje putem označenim ovim saobraćajnim znakom?";
                    dug1.Text = "Vozila čije je osovinsko opterećenje veće od određenog na znaku.";
                    dug2.Text = "Vozila čije je osovinsko opterećenje manje od određenog na znaku.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z32";
                    break;

                case 13:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je:";
                    dug1.Text = "zabrana saobraćaja za sva motorna vozila, osim motocikla bez prikolice i mopeda.";
                    dug2.Text = "zabrana saobraćaja za sva motorna vozila, osim motocikla bez prikolice.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z33";
                    break;

                case 14:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je?";
                    dug1.Text = "Zabrana saobraćaja za bicikla.";
                    dug2.Text = "Zabrana saobraćaja za bicikla i mopede.";
                    dug3.Text = "";
                    dug3.IsVisible = false;


                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z34";
                    break;

                case 15:
                    pitanje.Text = "Koje značenje ima ovaj saobraćajni znak?";
                    dug1.Text = "Obavezno obilaženje s lijeve strane.";
                    dug2.Text = "Obavezan smjer.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z35";
                    break;

                case 16:
                    pitanje.Text = "Šta zabranjuje ovaj saobraćajni znak?";
                    dug1.Text = "Zaustavljanje vozila.";
                    dug2.Text = "Parkiranje vozila.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z36";
                    break;

                case 17:
                    pitanje.Text = "Koja vozila se obilježavaju oznakama kao na slici?";
                    dug1.Text = "Teška vozila.";
                    dug2.Text = "Vozila šira od 2,5 m.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z37";
                    break;

                case 18:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je:";
                    dug1.Text = "prvenstvo prolaza za vozila iz suprotnog smjera.";
                    dug2.Text = "dozvoljeni smjer.";
                    dug3.Text = "saobraćaj u oba smjera.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    Tacanodg = dug3.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z38";
                    break;

                case 19:
                    pitanje.Text = "Koje značenje ima ovaj saobraćajni znak?";
                    dug1.Text = "Moguće neravnine i izbočine na putu.";
                    dug2.Text = "Opasnost od kamenja koje se odronjava na put.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z39";
                    break;

                case 20:
                    pitanje.Text = "Koje značenje ima ovaj saobraćajni znak?";
                    dug1.Text = "Blizina prelaza puta preko željezničke pruge u nivou koja nije obezbijeđena branicima ili polubranicima.";
                    dug2.Text = "Blizina prelaza puta preko željezničke pruge u nivou koja je obezbijeđena branicima ili polubranicima.";
                    dug3.Text = "Nailazak na drveni most.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z40";
                    break;


            }
        }

        
        private void klik(object sender, EventArgs e)
        {
            Button dugme = sender as Button;



            if (dugme.IsEnabled == true && dugme.BackgroundColor == Color.FromHex("#989898"))
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
                dugme.BackgroundColor = Color.FromHex("#989898");
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