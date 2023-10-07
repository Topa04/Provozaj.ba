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
    public partial class teolek2 : ContentPage
    {
        List<int> brojPitanja = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };


        int t = 0;
        int n = 0;
        int brPitanja = 0;
        int i;
        int rezultat;
        int brojTacnihOdg = 0;
        String Tacanodg = "";
        public teolek2()
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
                    pitanje.Text = "Prelaz alkohola u krv (resorpcija alkohola), završi se...";
                    dug1.Text = "najkasnije nakon jednog sata od konzumiranja alkohola.";
                    dug2.Text = "najkasnije nakon 24 sata od konzumiranja alkohola. ";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 2:
                    pitanje.Text = "Koje radnje nije preporučljivo vršiti za vrijeme upravljanja motornim vozilom u uslovima smanjene vidljivosti?";
                    dug1.Text = "Kretati se uz desnu ivicu kolovoza.";
                    dug2.Text = "Prelaziti u saobraćajnu traku namijenjenu za kretanje vozila iz suprotnog smjera.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 3:
                    pitanje.Text = "Koja je najmanja dozvoljena brzina kretanja motornog vozila na autoputu?";
                    dug1.Text = "40 km/h";
                    dug2.Text = "60 km/h";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 4:
                    pitanje.Text = "Najveći dozvoljeni poprečni nagib puta iznosi:";
                    dug1.Text = "10 %";
                    dug2.Text = "7 %";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 5:
                    pitanje.Text = "Da li je vozaču zabranjeno da pretiče vozilo koje se približava obilježenom pješačkom prelazu, ili koje prelazi pješački prelaz, ili koje je stalo radi propuštanja pješaka na tom prelazu?";
                    dug1.Text = "Nije, ukoliko postoje dvije saobraćajne trake u jednom smjeru.";
                    dug2.Text = "Nije, ukoliko ga pješaci propuštaju.";
                    dug3.Text = "Zabranjeno je.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    break;

                case 6:
                    pitanje.Text = "Kako ćete postupiti sa vozilom u saobraćaju u slučaju da na vozilu otkaže sistem radne kočnice?";
                    dug1.Text = "Zaustaviti vozilo uz korišćenje pomoćne kočnice i isključujete vozilo iz saobraćaja.";
                    dug2.Text = "Upravljati vozilom do prvog najbližeg servisa.";
                    dug3.Text = "Nastaviti upravljati vozilom uz korišćenje pomoćne kočnice.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 7:
                    pitanje.Text = "Šta se podrazumijeva pod pojmom „poseban objekat na putu“?";
                    dug1.Text = "Oprema na putu postavljena radi smanjenja brzine kretanja vozila na mjestima gdje je posebno ugrožena bezbjednost učesnika u saobraćaju.";
                    dug2.Text = "Zaštitne ograde i naplatne rampe.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 8:
                    pitanje.Text = "Šta se podrazumijeva pod pojmom „vozilo“?";
                    dug1.Text = "Svako prevozno sredstvo namijenjeno za kretanje po putu, osim pokretnih stolica bez motora za nemoćna lica i dječjih prevoznih sredstava.";
                    dug2.Text = "Svako motorno vozilo koje je namijenjeno za prevoz lica.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 9:
                    pitanje.Text = "U kojoj situaciji za vrijeme upravljanja vozilom vozač nije dužan da postupi na način određen saobraćajnim znakovima?";
                    dug1.Text = "Ako upravlja putničkim automobilom.";
                    dug2.Text = "Ako znak nije blagovremeno uočio.";
                    dug3.Text = "Ukoliko postupa po naredbi ovlaštenog lica.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    break;

                case 10:
                    pitanje.Text = "Dio površine puta namijenjen prvenstveno za saobraćaj vozila, naziva se:";
                    dug1.Text = "kolovozna traka";
                    dug2.Text = "kolovoz";
                    dug3.Text = "saobraćajna traka";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 11:
                    pitanje.Text = "Za osvjetljenje puta vozač motornog vozila u pravilu koristi:";
                    dug1.Text = "kratka svjetla";
                    dug2.Text = "duga svjetla";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 12:
                    pitanje.Text = "Na raskrsnici i na drugom mjestu na kojem je saobraćaj regulisan uređajima za davanje svjetlosnih saobraćajnih znakova, nakon gašenja „zelenog svjetla“, upaljeno „žuto svjetlo“ ima sljedeće značenje:";
                    dug1.Text = "obavezu za sve učesnike u saobraćaju da se kreću naročitom opreznošću.";
                    dug2.Text = "zabranu prolaza za sva vozila";
                    dug3.Text = "zabranu prolaza, osim za vozila koja se u času kad se žuto svjetlo pojavi nalaze na tolikoj udaljenosti od svjetlosnog saobraćajnog znaka da se ne mogu bezbjedno zaustaviti, a da ne prođu taj svjetlosni znak, a za ostale učesnike zabrana prolaza.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    break;

                case 13:
                    pitanje.Text = "Kojim vozilima imate pravo upravljati ukoliko imate vozačku dozvolu B kategorije? (2 tačna odgovora)";
                    dug1.Text = "Traktorom.";
                    dug2.Text = "Triciklom.";
                    dug3.Text = "Vozilom koje, osim sjedišta za vozača, ima više od osam sjedišta.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    dug2.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug1.Text + "' i '" + dug2.Text;
                    break;

                case 14:
                    pitanje.Text = "Da li se na autoput smije uključiti motorno vozilo koje vuče drugo motorno vozilo koje zbog neispravnosti ne može da se kreće?";
                    dug1.Text = "Nije regulisano propisom.";
                    dug2.Text = "Ne.";
                    dug3.Text = "Da.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 15:
                    pitanje.Text = "Kojim postupcima vozač ugrožava bezbjednost saobraćaja? (2 tačna odgovora)";
                    dug1.Text = "Ako vozilom upravlja umoran ili bolestan.";
                    dug2.Text = "Ako vozilom upravlja pod uticajem alkohola i opojnih sredstava.";
                    dug3.Text = "Ako se vozilom kreće uz desnu ivicu kolovoza.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    dug2.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug1.Text + "' i '" + dug2.Text;
                    break;

                case 16:
                    pitanje.Text = "Ako je vozilo kojim se prevoze djeca zaustavljeno na kolovozu, na putu sa dvije saobraćajne trake, dok djeca ulaze ili izlaze iz vozila, a vi tom vozilu dolazite u susret, dužni ste:";
                    dug1.Text = "zaustaviti vozilo dok djeca ulaze i izlaze iz vozila.";
                    dug2.Text = "smanjiti brzinu kretanja vozila i naročitom opreznošću nastaviti kretanje vozilom.";
                    dug3.Text = "smanjiti brzinu kretanja vozila i po potrebi zaustaviti vozilo.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 17:
                    pitanje.Text = "Svjetlo za vožnju unazad ne smije osvjetljavati put na dužini većoj od:";
                    dug1.Text = "7,5 m.";
                    dug2.Text = "10 m.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 18:
                    pitanje.Text = "Koliko vozila u nizu čini kolonu?";
                    dug1.Text = "Najmanje 3 vozila.";
                    dug2.Text = "Najmanje 5 vozila.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 19:
                    pitanje.Text = "Koje radnje morate preduzeti prije vršenja radnje polukružnog okretanja? (2 tačna odgovora)";
                    dug1.Text = "Predhodno se uvjeriti da je radnju moguće obaviti na bezbjedan način.";
                    dug2.Text = "Uključiti uređaj za istovremeno paljenje svih pokazivača smjera.";
                    dug3.Text = "Uključiti lijevi pokazivač smjera i vozilom zauzeti pravilan položaj u saobraćajnoj traci.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    dug3.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug1.Text + "' i '" + dug3.Text;
                    break;

                case 20:
                    pitanje.Text = "Pojam „saobraćajna traka“ podrazumijeva se:";
                    dug1.Text = "uzdužni dio kolovoza namijenjen za saobraćaj motornih vozila.";
                    dug2.Text = "obilježeni ili neobilježeni uzdužni dio kolovoza čija je širina dovoljna za nesmetan saobraćaj jednog reda vozila.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
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
                dugme.TextColor = Color.FromHex("#6d7278");
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