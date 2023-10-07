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
    public partial class teolek1 : ContentPage
    {
        List<int> brojPitanja = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};


        int t = 0;
        int n = 0;
        int brPitanja = 0;
        int i;
        int brojTacnihOdg = 0;
        String Tacanodg = "";
        public teolek1()
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
                    pitanje.Text = "Vozač je:";
                    dug1.Text = "svako lice koje se u saobraćaju na putu nalazi u vozilu.";
                    dug2.Text = "lice koje na putu upravlja vozilom.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 2:
                    pitanje.Text = "Svjetlosni saobraćajni znak „žuto trepćuće svjetlo“ obavezuje sve učesnike u saobraćaju:";
                    dug1.Text = "na najavu crvenog svjetla.";
                    dug2.Text = "na najavu zelenog svjetla.";
                    dug3.Text = "na kretanje sa povećanom opreznošću, i da uređaj za davanje svjetlosnih znakova nije u funkciji regulisanja saobraćaja.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    break;

                case 3:
                    pitanje.Text = "Kako se naziva uzdužni dio kolovoza namijenjen za saobraćaj vozila u jednom smjeru sa jednom ili više saobraćajnih traka? ";
                    dug1.Text = "Kolovozna traka.";
                    dug2.Text = "Kolovoz.";
                    dug3.Text = "Saobraćajna traka.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 4:
                    pitanje.Text = "Preglednost podrazumijeva:";
                    dug1.Text = "prostor koji učesnik u drumskom saobraćaju može da vidi s mjesta na kojem se nalazi.";
                    dug2.Text = "mjesto na raskrsnici s kojeg vozač vidi lijevo – desno najmanje 25 m.";
                    dug3.Text = "mjesto na raskrsnici s kojeg vozač vidi ulijevo najmanje 25 m.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 5:
                    pitanje.Text = "Stiker-naljepnica je:";
                    dug1.Text = "dokaz o izvršenom tehničkom pregledu.";
                    dug2.Text = "dokaz o plaćenoj putarini.";
                    dug3.Text = "dokaz o izvršenoj registraciji vozila.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    break;

                case 6:
                    pitanje.Text = "Za vrijeme upravljanja motornim vozilom na autoputu vozač ne smije: (2 tačna odgovora)";
                    dug1.Text = "mijenjati saobraćajnu traku kojom se predhodno kretao.";
                    dug2.Text = "kretati se vozilom unazad.";
                    dug3.Text = "obavljati radnju polukružnog okretanja. ";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    dug3.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug2.Text + "' i '" + dug3.Text;
                    break;

                case 7:
                    pitanje.Text = "Projektovanjem i gradnjom novih javnih puteva, osim lokalnih, mora se obezbijediti da podnesu osovinsko opterećenje od: ";
                    dug1.Text = "najmanje 10 t po osovini.";
                    dug2.Text = "najmanje 11,5 t po osovini.";
                    dug3.Text = "najmanje 11 t po osovini.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 8:
                    pitanje.Text = "Iznad kolovoza javnog puta mora da postoji slobodan prostor u visini od najmanje:";
                    dug1.Text = "4,5 m od najviše tačke kolovoza.";
                    dug2.Text = "4 m od najviše tačke kolovoza.";
                    dug3.Text = "6 m od najviše tačke kolovoza.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 9:
                    pitanje.Text = "Šta utiče na produženje puta kočenja? (2 tačna odgovora)";
                    dug1.Text = "Mokar kolovoz.";
                    dug2.Text = "Suv kolovoz.";
                    dug3.Text = "Opterećenje vozila.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    dug3.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug2.Text + "' i '" + dug3.Text;
                    break;

                case 10:
                    pitanje.Text = "Koja je najveća dozvoljena brzina kretanja za motorna vozila koja vuku prikolicu za stanovanje(karavan) ili laku prikolicu? ";
                    dug1.Text = "60 km/h";
                    dug2.Text = "80 km/h";
                    dug3.Text = "90 km/h";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 11:
                    pitanje.Text = "Novoproizvedena motorna i priključna vozila, nakon tehničkog pregleda prije prve registracije, vlasnici su dužni da odvezu na redovan tehnički pregled? ";
                    dug1.Text = "U toku mjeseca u kojem ističe rok od 36 mjeseci od dana prve registracije.";
                    dug2.Text = "U toku mjeseca u kojem ističe rok od 12 mjeseci od dana prve registracije.";
                    dug3.Text = "U toku mjeseca u kojem ističe rok od 24 mjeseca od dana prve registracije.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    break;

                case 12:
                    pitanje.Text = "Kako djeca najčešće reaguju u saobraćaju?";
                    dug1.Text = "Razumno i staloženo.";
                    dug2.Text = "U skladu sa propisima.";
                    dug3.Text = "Spontano i nepredvidivo.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    break;

                case 13:
                    pitanje.Text = "Kako svojim ponašanjem u saobraćaju, za vrijeme upravljanja vozilom, možete doprinijeti smanjenju saobraćajnog rizika? (2 tačna odgovora)";
                    dug1.Text = "Agresivnom vožnjom.";
                    dug2.Text = "Poštovanjem saobraćajnih pravila i propisa.";
                    dug3.Text = "Defanzivnom vožnjom.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    dug3.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug2.Text + "' i '" + dug3.Text;
                    break;

                case 14:
                    pitanje.Text = "Pomoću užeta ne smije da se vuče motorno vozilo: (2 tačna odgovora)";
                    dug1.Text = "Na kojem su neispravni uređaji za osvjetljаvanje puta, označavanje vozila i za davanje svjetlosnih znakova.";
                    dug2.Text = "Na kojem su neispravni uređaji za zaustavljanje.";
                    dug3.Text = "Na kojem su neispravni uređaji za upravljanje.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    dug3.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug2.Text + "' i '" + dug3.Text;
                    break;

                case 15:
                    pitanje.Text = "Za koji period važi ljekarsko uvjerenje o zdravstvenoj sposobnosti za upravljanje motornim vozilom?";
                    dug1.Text = "12 mjeseci od dana izdavanja.";
                    dug2.Text = "6 mjeseci od dana izdavanja.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 16:
                    pitanje.Text = "Krutom vezom (rudom) ne smije da se vuče motorno vozilo:";
                    dug1.Text = "koje ima ispravan uređaj za upravljanje.";
                    dug2.Text = "koje je teže od vučnog vozila, ako mu je neispravna pomoćna kočnica.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 17:
                    pitanje.Text = "Zaustavljanje vozila je:";
                    dug1.Text = "svaki prekid kretanja vozila do 15 minuta, osim prekida kretanja koji se pravi da bi se postupilo po znaku ili pravilu saobraćaja.";
                    dug2.Text = "svaki prekid kretanja vozila do 5 minuta, osim prekida kretanja koji se pravi da bi se postupilo po znaku ili pravilu kojim se reguliše saobraćaj. ";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 18:
                    pitanje.Text = "Pješak je:";
                    dug1.Text = "lice koje se vozi na koturaljkama.";
                    dug2.Text = "lice koje upravlja vozilom, ili se prevozi u vozilu ili na vozilu.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 19:
                    pitanje.Text = "Koliko kolovoznih traka ima put s jednosmjernim saobraćajem?";
                    dug1.Text = "Dvije kolovozne trake.";
                    dug2.Text = "Jednu kolovoznu traku.";
                    dug3.Text = "Više od dvije kolovozne trake.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 20:
                    pitanje.Text = "Gdje se na putu postavljaju smjerokazni stubići sa crvenim reflektujućim katadiopterima?";
                    dug1.Text = "Uz lijevu ivicu kolovoza.";
                    dug2.Text = "Uz desnu ivicu kolovoza.";
                    dug3.Text = "Samo ispred opasnih krivina.";
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