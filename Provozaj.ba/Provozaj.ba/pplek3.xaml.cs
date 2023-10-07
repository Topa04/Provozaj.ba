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
    public partial class pplek3 : ContentPage
    {
        List<int> brojPitanja = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        int t = 0;
        int n = 0;
        int brPitanja = 0;
        int i;
        int rezultat;
        int brojTacnihOdg = 0;
        String Tacanodg = "";
        public pplek3()
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
                    pitanje.Text = "Koji su neki od znakova moždanog udara?";
                    dug1.Text = "Teškoće sa vidom, problemi u govoru i gubitak ravnoteže.";
                    dug2.Text = "Iskašljavanje krvave pjene.";
                    dug3.Text = "Svrbež i peckanje kože.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 2:
                    pitanje.Text = "U kojem položaju se transportuje osoba sa povredom natkoljenice?";
                    dug1.Text = "U ležećem položaju sa prethodno izvršenom imobilizacijom.";
                    dug2.Text = "U sjedećem položaju sa prethodno izvršenom imobilizacijom.";
                    dug3.Text = "Nije bitan položaj, bitna je imobilizacija.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 3:
                    pitanje.Text = "Koji su neki od znakova epileptičnih napada?";
                    dug1.Text = "Trzanje – grčenje ekstremiteta i/ili cijelog tijela praćeno besvjesnim stanjem, nekad i umokravanje.";
                    dug2.Text = "Ubrzano disanje.";
                    dug3.Text = "Groznica i povišena tjelesna temperatura.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 4:
                    pitanje.Text = "Kako se provjerava gubitak svijesti?";
                    dug1.Text = "Metodom gledam, slušam, osjećam.";
                    dug2.Text = "Pritiskom na glavu i čelo da osoba otvori oči i upitom šta se dogodilo.";
                    dug3.Text = "Glasnim dozivanjem (komunikacija govorom), hvatanjem za ramena, laganim protresanjem ramena bez pomicanja.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    break;

                case 5:
                    pitanje.Text = "Kada se primjenjuje Hajmlihov hvat?";
                    dug1.Text = "Kod gušenja ugljen-monoksidom.";
                    dug2.Text = "Kod gušenja stranim tijelom.";
                    dug3.Text = "Kod utapanja.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 6:
                    pitanje.Text = "Zbog čega su opasne opekotine koje zahvataju veću površinu tijela?";
                    dug1.Text = "Zbog nastanka upale pluća.";
                    dug2.Text = "Zbog gubitka veće količine tečnosti i infekcije.";
                    dug3.Text = "Zbog gubitka veće količine krvi.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 7:
                    pitanje.Text = "Prema kojim sljedećim simptomima i znacima prepoznajemo osobu koja je jako iskrvarila?";
                    dug1.Text = "Osoba je modra u licu, uznemirena, konfuzna, puls je usporen ali se normalno lako napipa, diše duboko, osjeća slabost.";
                    dug2.Text = "Osoba je malo blijeda, modra u licu, nije raspoložena, više je nemirna, osjeća opštu slabost i malaksalost.";
                    dug3.Text = "Osoba ja izrazito blijeda, kože orošene hladnim i ljepljivim znojem, suvih usta, osjeća žeđ, opštu slabost i malaksalost do klonulosti.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    break;

                case 8:
                    pitanje.Text = "U koji položaj postavljamo povrijeđenog kod povrede kostiju karlice?";
                    dug1.Text = "Ostavljamo povrijeđenog u zatečenom položaju.";
                    dug2.Text = "U bočni ili koma položaj.";
                    dug3.Text = "U položaj autotransfuzije.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 9:
                    pitanje.Text = "Koja je pravilna metoda zaustavljanja krvarenja?";
                    dug1.Text = "Podvezivanje uda.";
                    dug2.Text = "Direktan pritisak na ranu.";
                    dug3.Text = "Autotransfuzija.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 10:
                    pitanje.Text = "Koji je postupak pružanja prve pomoći kod otvorenog preloma kosti bez krvarenja?";
                    dug1.Text = "Imobilizacija i hitan transport.";
                    dug2.Text = "Prekrivanje rane sterilnom gazom, istezanje, hitan transport.";
                    dug3.Text = "Prekrivanje rane sterilnom gazom, imobilizacija, transport nije hitan.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
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