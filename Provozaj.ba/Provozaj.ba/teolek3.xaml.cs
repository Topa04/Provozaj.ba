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
    public partial class teolek3 : ContentPage
    {
        List<int> brojPitanja = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };


        int t = 0;
        int n = 0;
        int brPitanja = 0;
        int i;
        int rezultat;
        int brojTacnihOdg = 0;
        String Tacanodg = "";
        public teolek3()
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
                    pitanje.Text = "Kojim vozilima imate pravo upravljati ukoliko imate vozačku dozvolu B kategorije? (2 tačna odgovora)";
                    dug1.Text = "Mopedom.";
                    dug2.Text = "Četvorociklom.";
                    dug3.Text = "Vozilima čija je najveća dozvoljena masa veća od 3500 kg.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    dug2.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug1.Text + "' i '" + dug2.Text;
                    break;

                case 2:
                    pitanje.Text = "Vozaču kojem je u roku od jedne godine zbog učinjenih prekršaja iz Zakona o osnovama bezbjednosti saobraćaja na putevima u Bosni i Hercegovini određeno najmanje 10 kaznenih bodova: (2 tačna odgovora)";
                    dug1.Text = "biće oduzeta vozačka dozvola u trajanju od 60 dana.";
                    dug2.Text = "biće oduzeta vozačka dozvola u trajanju od 30 dana.";
                    dug3.Text = "biće upućen na provjeru poznavanja saobraćajnih propisa.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    dug3.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug2.Text + "' i '" + dug3.Text;
                    break;

                case 3:
                    pitanje.Text = "Vozač koji na provjeri poznavanja saobraćajnih propisa ne pokaže potrebno znanje može, na svoj zahtjev, pristupiti ponovo provjeri:";
                    dug1.Text = "poslije isteka 15 dana od dana prethodne provjere.";
                    dug2.Text = "poslije isteka 30 dana od dana prethodne provjere.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 4:
                    pitanje.Text = "Uređaj za vožnju unazad, kad je upaljen, mora osvjetljavati put svjetlom:";
                    dug1.Text = "bijele boje.";
                    dug2.Text = "bijele ili žute boje.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 5:
                    pitanje.Text = "Osnovna boja znakova opasnosti je?";
                    dug1.Text = "Žuta a ivice trougla su crvene.";
                    dug2.Text = "Plava a simboli i natpisi su bijele boje.";
                    dug3.Text = "Bijela a ivice trougla su crvene.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    break;

                case 6:
                    pitanje.Text = "Uređaj za upravljanje vozilom mora biti pouzdan i izveden tako da: (2 tačna odgovora)";
                    dug1.Text = "vozač može lako, brzo i na siguran način mijenjati smjer kretanja vozila.";
                    dug2.Text = "se prednji točkovi vozila, pri kretanju vozila po vodoravnoj ravnoj površini, nakon oslobađanja točka upravljača, sami vraćaju u položaj za pravolinijsko kretanje.";
                    dug3.Text = "omogućava slobodan hod točka upravljača na vozilu veći od 30°.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    dug2.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug1.Text + "' i '" + dug2.Text;
                    break;

                case 7:
                    pitanje.Text = "Kako će ovlašteno lice postupiti prema vozaču koji odbije da se podvrgne ispitivanju, odnosno stručnom pregledu na koji je upućen radi provjeravanja da li ima alkohola u organizmu ili da li pokazuje znakove poremećenosti izazavane djejstvom alkohola?";
                    dug1.Text = "Odrediće mu rok u kojem se mora podvrgnuti ispitivanju, odnosno pregledu.";
                    dug2.Text = "Na licu mjesta će mu privremeno oduzeti vozačku dozvolu.";
                    dug3.Text = "Isključiti vozilo iz saobraćaja.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 8:
                    pitanje.Text = "«Stop-svjetla» ne moraju imati vozila koja na ravnom putu ne mogu razviti brzinu veću od:";
                    dug1.Text = "25 km/h";
                    dug2.Text = "30 km/h";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 9:
                    pitanje.Text = "Radna mašina po svojim konstrukcionim osobinama ne može razviti brzinu veću od:";
                    dug1.Text = "25 km/h";
                    dug2.Text = "30 km/h";
                    dug3.Text = "40 km/h";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 10:
                    pitanje.Text = "Centralni registar“ je evidencija:";
                    dug1.Text = "samo o vozačima.";
                    dug2.Text = "samo o vozilima.";
                    dug3.Text = "o svim vozačima i vozilima.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    break;

                case 11:
                    pitanje.Text = "„Brzi put“, u pravilu:";
                    dug1.Text = "nema zaustavnih traka.";
                    dug2.Text = "ima zaustavnih traka.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 12:
                    pitanje.Text = "Međunarodna vozačka dozvola izdaje se na period važenja od:";
                    dug1.Text = "jedne godine.";
                    dug2.Text = "dvije godine, odnosno na period propisan međunarodnim ugovorom.";
                    dug3.Text = "tri godine.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 13:
                    pitanje.Text = "Izdata vam je vozačka dozvola za C1 podkategoriju. Kojim vozilima imate pravo upravljati?";
                    dug1.Text = "Vozilima koja, osim sjedišta za vozača, imaju više od osam sjedišta, a manje od šesnaest sjedišta.";
                    dug2.Text = "Vozilima čija je najveća dozvoljena masa veća od 3500kg, a manja od 7500 kg.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 14:
                    pitanje.Text = "Vozačka dozvola koja se izdaje licu starijem od 65 godina života produžava se sa rokom važenja od:";
                    dug1.Text = "tri godine.";
                    dug2.Text = "dvije godine.";
                    dug3.Text = "deset godina.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 15:
                    pitanje.Text = "Ispod slova „L” na tablici kojom se obilježava vozilo za osposobljavanje kandidata za vozača iz upravljanja motornim vozilom upisuje se: (2 tačna odgovora)";
                    dug1.Text = "broj instruktorske dozvole instruktora vožnje.";
                    dug2.Text = "registarski broj vozila za koji se tablica koristi.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug2.Text;
                    break;

                case 16:
                    pitanje.Text = "Ispod slova „P” kojim se obilježava vozilo kojim upravlja vozač početnik mora biti ispisan:";
                    dug1.Text = "registarski broj vozila.";
                    dug2.Text = "broj vozačke dozvole vozača početnika.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 17:
                    pitanje.Text = "Najmanja dopuštena dubina kanala na gaznoj površini pneumatika za putnička vozila je:";
                    dug1.Text = "1 mm";
                    dug2.Text = "1,6 mm";
                    dug3.Text = "2 mm";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    break;

                case 18:
                    pitanje.Text = "Ispred kolskog ulaza u zgradu, dvorište ili garažu vozač ne smije da:";
                    dug1.Text = "parkira vozilo.";
                    dug2.Text = "zaustavi vozilo.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    break;

                case 19:
                    pitanje.Text = "Da li se u saobraćaju smije koristiti vozačka dozvola za koju je izdat duplikat?(2 tačna odgovora)";
                    dug1.Text = "Ne.";
                    dug2.Text = "Da.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug1.Text;
                    break;

                case 20:
                    pitanje.Text = "U kojem slučaju će vozaču biti oduzeta vozačka dozvola u trajanju od 30 dana?";
                    dug1.Text = "Ako mu, u roku od jedne godine, zbog učinjenih prekršaja iz Zakona o osnovama bezbjednosti saobraćaja na putevima u BiH bude određeno najmanje 7 kaznenih bodova.";
                    dug2.Text = "Ako mu, u roku od jedne godine zbog učinjenih prekršaja iz Zakona o osnovama bezbjednosti saobraćaja na putevima u BiH, bude određeno najmanje 10 kaznenih bodova.";
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