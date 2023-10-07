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
    public partial class B_kategorijaProbni : ContentPage
    {
        List<int> brojPitanja = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 ,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40};

        int t = 0;
        int n = 0;
        int brPitanja = 0;
        int i;
        int rezultat;
        int brojTacnihOdg = 0;
        String Tacanodg = "";
        int teo = 0;
        int zna = 0;
        int ras = 0;
        public B_kategorijaProbni()
        {
            InitializeComponent();
            slijedecePitanje();
        }
        

        private void Restart()
        {
            rezultat = 0;
            brPitanja = -1;
            i = 0;
            t = 0;
            n = 0;
            teo = 0;
            zna = 0;
            ras = 0;
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
                if (rezultat >= 108)
                {
                    await DisplayAlert("Završili ste probni test", "Čestitamo! Imali ste " + rezultat + " bodova.", "Nazad na B kategoriju");
                    Restart();
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Završili ste probni test", "Nažalost, imali ste samo " + rezultat + " bodova.", "Nazad na B kategoriju");
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
                    pitanje.Text = "Preglednost podrazumijeva:";
                    dug1.Text = "prostor koji učesnik u drumskom saobraćaju može da vidi s mjesta na kojem se nalazi.";
                    dug2.Text = "mjesto na raskrsnici s kojeg vozač vidi lijevo – desno najmanje 25 m.";
                    dug3.Text = "mjesto na raskrsnici s kojeg vozač vidi ulijevo najmanje 25 m.";
                    dug3.TextTransform = 0;
                    dug3.IsVisible = true;
                    slikapit.IsVisible = false;
                    okvir.Margin = new Thickness(20, 120, 20, 0);
                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    teo = 2;
                    zna = 0;
                    ras = 0;
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
                    teo = 2;
                    zna = 0;
                    ras = 0;
                    break;
                case 3:
                    pitanje.Text = "Projektovanjem i gradnjom novih javnih puteva, osim lokalnih, mora se obezbijediti da podnesu osovinsko opterećenje od: ";
                    dug1.Text = "najmanje 10 t po osovini.";
                    dug2.Text = "najmanje 11,5 t po osovini.";
                    dug3.Text = "najmanje 11 t po osovini.";
                    dug3.IsVisible = true;
                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    teo = 2;
                    zna = 0;
                    ras = 0;
                    break;
                case 4:
                    pitanje.Text = "Šta utiče na produženje puta kočenja? (2 tačna odgovora)";
                    dug1.Text = "Mokar kolovoz.";
                    dug2.Text = "Suv kolovoz.";
                    dug3.Text = "Opterećenje vozila.";
                    dug3.IsVisible = true;
                    dug1.TabIndex = 1;
                    dug3.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug1.Text + "' i '" + dug3.Text;
                    teo = 2;
                    zna = 0;
                    ras = 0;
                    break;
                case 5:
                    pitanje.Text = "Kako svojim ponašanjem u saobraćaju, za vrijeme upravljanja vozilom, možete doprinijeti smanjenju saobraćajnog rizika? (2 tačna odgovora)";
                    dug1.Text = "Agresivnom vožnjom.";
                    dug2.Text = "Poštovanjem saobraćajnih pravila i propisa.";
                    dug3.Text = "Defanzivnom vožnjom.";
                    dug3.IsVisible = true;
                    dug2.TabIndex = 1;
                    dug3.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug2.Text + "' i '" + dug3.Text;
                    teo = 2;
                    zna = 0;
                    ras = 0;
                    break;
                case 6:
                    pitanje.Text = "Koliko kolovoznih traka ima put s jednosmjernim saobraćajem?";
                    dug1.Text = "Dvije kolovozne trake.";
                    dug2.Text = "Jednu kolovoznu traku.";
                    dug3.Text = "Više od dvije kolovozne trake.";
                    dug3.IsVisible = true;
                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    teo = 2;
                    zna = 0;
                    ras = 0;
                    break;
                case 7:
                    pitanje.Text = "Koje radnje nije preporučljivo vršiti za vrijeme upravljanja motornim vozilom u uslovima smanjene vidljivosti?";
                    dug1.Text = "Kretati se uz desnu ivicu kolovoza.";
                    dug2.Text = "Prelaziti u saobraćajnu traku namijenjenu za kretanje vozila iz suprotnog smjera.";
                    dug3.Text = "";
                    dug3.IsVisible = false;
                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    teo = 2;
                    zna = 0;
                    ras = 0;
                    break;
                case 8:
                    pitanje.Text = "Kako ćete postupiti sa vozilom u saobraćaju u slučaju da na vozilu otkaže sistem radne kočnice?";
                    dug1.Text = "Zaustaviti vozilo uz korišćenje pomoćne kočnice i isključujete vozilo iz saobraćaja.";
                    dug2.Text = "Upravljati vozilom do prvog najbližeg servisa.";
                    dug3.Text = "Nastaviti upravljati vozilom uz korišćenje pomoćne kočnice.";
                    dug3.IsVisible = true;
                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    teo = 2;
                    zna = 0;
                    ras = 0;
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
                    teo = 2;
                    zna = 0;
                    ras = 0;
                    break;
                case 10:
                    pitanje.Text = "Kojim vozilima imate pravo upravljati ukoliko imate vozačku dozvolu B kategorije? (2 tačna odgovora)";
                    dug1.Text = "Traktorom.";
                    dug2.Text = "Triciklom.";
                    dug3.Text = "Vozilom koje, osim sjedišta za vozača, ima više od osam sjedišta.";
                    dug3.IsVisible = true;
                    dug1.TabIndex = 1;
                    dug2.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug1.Text + "' i '" + dug2.Text;
                    teo = 2;
                    zna = 0;
                    ras = 0;
                    break;
                case 11:
                    pitanje.Text = "Kojim postupcima vozač ugrožava bezbjednost saobraćaja? (2 tačna odgovora)";
                    dug1.Text = "Ako vozilom upravlja umoran ili bolestan.";
                    dug2.Text = "Ako vozilom upravlja pod uticajem alkohola i opojnih sredstava.";
                    dug3.Text = "Ako se vozilom kreće uz desnu ivicu kolovoza.";
                    dug3.IsVisible = true;
                    dug1.TabIndex = 1;
                    dug2.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug1.Text + "' i '" + dug2.Text;
                    teo = 2;
                    zna = 0;
                    ras = 0;
                    break;

                case 12:
                    pitanje.Text = "Koliko vozila u nizu čini kolonu?";
                    dug1.Text = "Najmanje 3 vozila.";
                    dug2.Text = "Najmanje 5 vozila.";
                    dug3.Text = "";
                    dug3.IsVisible = false;
                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    teo = 2;
                    zna = 0;
                    ras = 0;
                    break;
                case 13:
                    pitanje.Text = "Prelaz alkohola u krv (resorpcija alkohola), završi se...";
                    dug1.Text = "najkasnije nakon jednog sata od konzumiranja alkohola.";
                    dug2.Text = "najkasnije nakon 24 sata od konzumiranja alkohola. ";
                    dug3.Text = "";
                    dug3.IsVisible = false;
                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    teo = 2;
                    zna = 0;
                    ras = 0;
                    break;
                case 14:
                    pitanje.Text = "Pojam „saobraćajna traka“ podrazumijeva se:";
                    dug1.Text = "uzdužni dio kolovoza namijenjen za saobraćaj motornih vozila.";
                    dug2.Text = "obilježeni ili neobilježeni uzdužni dio kolovoza čija je širina dovoljna za nesmetan saobraćaj jednog reda vozila.";
                    dug3.Text = "";
                    dug3.IsVisible = false;
                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    teo = 2;
                    zna = 0;
                    ras = 0;
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
                    teo = 2;
                    zna = 0;
                    ras = 0;
                    break;
                case 16:
                    pitanje.Text = "Kako će ovlašteno lice postupiti prema vozaču koji odbije da se podvrgne ispitivanju, odnosno stručnom pregledu na koji je upućen radi provjeravanja da li ima alkohola u organizmu ili da li pokazuje znakove poremećenosti izazavane djejstvom alkohola?";
                    dug1.Text = "Odrediće mu rok u kojem se mora podvrgnuti ispitivanju, odnosno pregledu.";
                    dug2.Text = "Na licu mjesta će mu privremeno oduzeti vozačku dozvolu.";
                    dug3.Text = "Isključiti vozilo iz saobraćaja.";
                    dug3.IsVisible = true;
                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    teo = 2;
                    zna = 0;
                    ras = 0;
                    break;
                case 17:
                    pitanje.Text = "Vozač koji na provjeri poznavanja saobraćajnih propisa ne pokaže potrebno znanje može, na svoj zahtjev, pristupiti ponovo provjeri:";
                    dug1.Text = "poslije isteka 15 dana od dana prethodne provjere.";
                    dug2.Text = "poslije isteka 30 dana od dana prethodne provjere.";
                    dug3.Text = "";
                    dug3.IsVisible = false;
                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    teo = 2;
                    zna = 0;
                    ras = 0;
                    break;
                case 18:
                    pitanje.Text = "Kojim vozilima imate pravo upravljati ukoliko imate vozačku dozvolu B kategorije? (2 tačna odgovora)";
                    dug1.Text = "Mopedom.";
                    dug2.Text = "Četvorociklom.";
                    dug3.Text = "Vozilima čija je najveća dozvoljena masa veća od 3500 kg.";
                    dug3.IsVisible = true;
                    dug1.TabIndex = 1;
                    dug2.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug1.Text + "' i '" + dug2.Text;
                    teo = 2;
                    zna = 0;
                    ras = 0;
                    break;
                case 19:
                    pitanje.Text = "Da li se u saobraćaju smije koristiti vozačka dozvola za koju je izdat duplikat?";
                    dug1.Text = "Ne.";
                    dug2.Text = "Da.";
                    dug3.Text = "";
                    dug3.IsVisible = false;
                    dug1.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug1.Text;
                    teo = 2;
                    zna = 0;
                    ras = 0;
                    break;
                case 20:
                    pitanje.Text = "Radna mašina po svojim konstrukcionim osobinama ne može razviti brzinu veću od:";
                    dug1.Text = "25 km/h";
                    dug2.Text = "30 km/h";
                    dug3.Text = "40 km/h";
                    dug3.IsVisible = true;
                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    teo = 2;
                    zna = 0;
                    ras = 0;
                    break;
                case 21:
                    pitanje.Text = "Kako treba postupiti nailaskom na ovaj saobraćajni znak?";
                    dug1.Text = "Pripremiti se za savladavanje više uzastopnih krivina od kojih je prva udesno.";
                    dug2.Text = "Učesnike u saobraćaju iza sebe upozoriti desnim pokazivačem pravca.";
                    dug3.Text = "";
                    dug3.IsVisible = false;
                    slikapit.IsVisible = true;
                    slikapit.HeightRequest = 250;
                    slikapit.Margin = new Thickness(50, -5, 50, 20);
                    okvir.Margin = new Thickness(20, -20, 20, 0);
                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    slikapit.Source = "z2";
                    teo = 0;
                    zna = 3;
                    ras = 0;
                    break;
                case 22:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je?";
                    dug1.Text = "Zabrana saobraćaja za sva motorna vozila koja vuku priključno vozilo.";
                    dug2.Text = "Zabrana saobraćaja za sva motorna vozila koja vuku laku prikolicu.";
                    dug3.Text = "";
                    dug3.IsVisible = false;
                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    slikapit.Source = "z5";
                    teo = 0;
                    zna = 3;
                    ras = 0;
                    break;
                case 23:
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
                    teo = 0;
                    zna = 3;
                    ras = 0;
                    break;
                case 24:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je?";
                    dug1.Text = "Blizina mjesta na kojem se nalazi autopraonica.";
                    dug2.Text = "Blizina mjesta gdje je zabranjeno pranje vozila.";
                    dug3.Text = "";
                    dug3.IsVisible = false;
                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z16";
                    teo = 0;
                    zna = 3;
                    ras = 0;
                    break;
                case 25:
                    pitanje.Text = "Šta zabranjuje ovaj saobraćajni znak?";
                    dug1.Text = "Zaustavljanje vozila.";
                    dug2.Text = "Parkiranje vozila.";
                    dug3.Text = "";
                    dug3.IsVisible = false;
                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z36";
                    teo = 0;
                    zna = 3;
                    ras = 0;
                    break;
                case 26:
                    pitanje.Text = "Koje značenje ima ovaj saobraćajni znak?";
                    dug1.Text = "Moguće neravnine i izbočine na putu.";
                    dug2.Text = "Opasnost od kamenja koje se odronjava na put.";
                    dug3.Text = "";
                    dug3.IsVisible = false;
                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z39";
                    teo = 0;
                    zna = 3;
                    ras = 0;
                    break;
                case 27:
                    pitanje.Text = "Kako ćete postupiti nailaskom na ovaj saobraćajni znak?";
                    dug1.Text = "Uz povećanu pažnju nastaviti kretanje vozilom, jer imam pravo prvenstva prolaza u odnosu na vozila koja dolaze iz suprotnog smjera.";
                    dug2.Text = "Zaustaviti vozilo i propustiti vozila iz suprotnog smjera.";
                    dug3.Text = "";
                    dug3.IsVisible = false;
                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    slikapit.Source = "z25";
                    teo = 0;
                    zna = 3;
                    ras = 0;
                    break;
                case 28:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je?";
                    dug1.Text = "Put sa jednosmjernim saobraćajem.";
                    dug2.Text = "Obavezan smjer.";
                    dug3.Text = "";
                    dug3.IsVisible = false;
                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    slikapit.Source = "z44";
                    teo = 0;
                    zna = 3;
                    ras = 0;
                    break;
                case 29:
                    pitanje.Text = "Kako treba postupiti nailaskom na ovaj saobraćajni znak? (2 tačna odgovora)";
                    dug1.Text = "Povećati pažnju.";
                    dug2.Text = "Povećati brzinu kretanja vozila.";
                    dug3.Text = "Smanjiti brzinu kretanja vozila.";
                    dug3.IsVisible = true;
                    dug1.TabIndex = 1;
                    dug3.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug1.Text + "' i '" + dug3.Text;
                    slikapit.Source = "z56";
                    teo = 0;
                    zna = 3;
                    ras = 0;
                    break;
                case 30:
                    pitanje.Text = "Koje značenje ima ovaj saobraćajni znak?";
                    dug1.Text = "Obavezan smjer.";
                    dug2.Text = "Obavezno polukružno okretanje.";
                    dug3.Text = "";
                    dug3.IsVisible = false;
                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z60";
                    teo = 0;
                    zna = 3;
                    ras = 0;
                    break;
                case 31:
                    pitanje.Text = "Kako u saobraćajnoj situaciji kao na slici mora postupiti vozač vozila broj 1:";
                    dug1.Text = "Propustiti vozilo broj 3, a zatim proći prije vozila broj 2";
                    dug2.Text = "Propustiti vozilo broj 3, zatim propustiti vozilo broj 2 i zadnji proći kroz raskrsnicu.";
                    dug3.Text = "odg 3.";
                    dug3.IsVisible = false;
                    slikapit.HeightRequest = 282;
                    slikapit.Margin = new Thickness(20, -5, 20, 20);
                    okvir.Margin = new Thickness(20, -20, 20, 0);
                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r4";
                    teo = 0;
                    zna = 0;
                    ras = 5;
                    break;
                case 32:
                    pitanje.Text = "Da li je u saobraćajnoj situaciji kao na slici dozvoljeno izvršiti radnju polukružnog okretanja vozilom?";
                    dug1.Text = "Da";
                    dug2.Text = "Ne";
                    dug3.Text = "odg 3.";
                    dug3.IsVisible = false;
                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r9";
                    teo = 0;
                    zna = 0;
                    ras = 5;
                    break;
                case 33:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "1 – 3 – 2";
                    dug2.Text = "2 – 3 – 1";
                    dug3.Text = "2 – 1 – 3";
                    dug3.IsVisible = true;
                    dug3.TabIndex = 1;
                    Tacanodg = dug3.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r18";
                    teo = 0;
                    zna = 0;
                    ras = 5;
                    break;
                case 34:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "1 – 2 – 3";
                    dug2.Text = "1 – 3 – 2";
                    dug3.Text = "3 – 1 – 2";
                    dug3.IsVisible = true;
                    slikapit.IsVisible = true;
                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    slikapit.Source = "r22";
                    teo = 0;
                    zna = 0;
                    ras = 5;
                    break;
                case 35:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "2 – 1 – 3";
                    dug2.Text = "3 – 2 – 1";
                    dug3.Text = "1 – 3 – 2";
                    dug3.IsVisible = true;
                    slikapit.IsVisible = true;
                    dug3.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug3.Text;
                    slikapit.Source = "r26";
                    break;
                case 36:
                    pitanje.Text = "Kako u saobraćajnoj situaciji kao na slici mora postupiti vozač vozila broj 2?";
                    dug1.Text = "Proći prije vozila broj 1;";
                    dug2.Text = "propustiti vozilo broj 1.";
                    dug3.Text = "";
                    dug3.IsVisible = false;
                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r30";
                    teo = 0;
                    zna = 0;
                    ras = 5;
                    break;
                case 37:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "3 – 2 – 1;";
                    dug2.Text = "2 – 1 – 3";
                    dug3.Text = "1 – 2 – 3";
                    dug3.IsVisible = true;
                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r40";
                    teo = 0;
                    zna = 0;
                    ras = 5;
                    break;
                case 38:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "1 – 3 – 2";
                    dug2.Text = "3 – 2 – 1";
                    dug3.Text = "2 – 3 – 1";
                    dug3.IsVisible = true;
                    dug3.TabIndex = 1;
                    Tacanodg = dug3.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r50";
                    teo = 0;
                    zna = 0;
                    ras = 5;
                    break;
                case 39:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "2 – 3 – 1";
                    dug2.Text = "2 – 1 – 3";
                    dug3.Text = "3 – 1 – 2";
                    dug3.IsVisible = true;
                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r8";
                    teo = 0;
                    zna = 0;
                    ras = 5;
                    break;
                case 40:
                    pitanje.Text = "Kako u saobraćajnoj situaciji kao na slici mora postupiti vozač vozila broj 2:";
                    dug1.Text = "Zaustaviti se i propustiti vozilo broj 1";
                    dug2.Text = "Proći prije vozila broj 1";
                    dug3.Text = "odg 3.";
                    dug3.IsVisible = false;
                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r20";
                    teo = 0;
                    zna = 0;
                    ras = 5;
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
                rezultat+=teo+zna+ras;
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