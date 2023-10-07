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
    public partial class znalek3 : ContentPage
    {
        List<int> brojPitanja = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        int t = 0;
        int n = 0;
        int brPitanja = 0;
        int i;
        int rezultat;
        int brojTacnihOdg = 0;
        String Tacanodg = "";
        public znalek3()
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
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je?";
                    dug1.Text = "Zabrana saobraćaja za vozila koja prevoze opasne materije.";
                    dug2.Text = "Zabrana saobraćaja za teretna vozila koja prevoze opasne materije.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    slikapit.Source = "z41";
                    break;

                case 2:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je?";
                    dug1.Text = "Zabrana saobraćaja za vozila koja prekoračuju određeno dvoosovinsko opterećenje.";
                    dug2.Text = "Zabrana saobraćaja za vozila čije opterećenje po jednostrukoj osovini prelazi opterećenje označeno na znaku.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    slikapit.Source = "z42";
                    break;

                case 3:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je?";
                    dug1.Text = "Pješačka staza.";
                    dug2.Text = "Zona smirenog saobraćaja.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    slikapit.Source = "43";
                    break;

                case 4:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je?";
                    dug1.Text = "Put sa jednosmjernim saobraćajem.";
                    dug2.Text = "Obavezan smjer.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug2.Text;
                    slikapit.Source = "z44";
                    break;

                case 5:
                    pitanje.Text = "Koja vozila se obilježavaju oznakom kao na slici?";
                    dug1.Text = "Duga vozila.";
                    dug2.Text = "Vozila čija širina prelazi 2,5m.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    brojTacnihOdg = 1;
                    Tacanodg = dug1.Text;
                    slikapit.Source = "z45";
                    break;

                case 6:
                    pitanje.Text = "Šta može imati za posljedicu nepoštovanje ovog znaka? (2 tačna odgovora)";
                    dug1.Text = "Moguće zanošenje i izlijetanje vozila sa kolovoza.";
                    dug2.Text = "Veću kontrolu prilikom upravljanja vozilom.";
                    dug3.Text = "Moguće oštećenje ili lomljenje dijelova na vozilu.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    dug3.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug1.Text + "' i '" + dug3.Text;
                    slikapit.Source = "z46";
                    break;

                case 7:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je?";
                    dug1.Text = "Pokretni most.";
                    dug2.Text = "Blizina obale.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z47";
                    break;

                case 8:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je?";
                    dug1.Text = "Životinje na putu.";
                    dug2.Text = "Divljač na putu.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z48";
                    break;

                case 9:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je?";
                    dug1.Text = "Zabrana preticanja svih motornih vozila, osim motocikla bez prikolice i mopeda.";
                    dug2.Text = "Zabrana preticanja svih motornih vozila, osim mopeda.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z49";
                    break;

                case 10:
                    pitanje.Text = "Kojim vozilima nije dozvoljeno kretanje putem označenim ovim saobraćajnim znakom?";
                    dug1.Text = "Vozilima čija ukupna visina premašuje visinu označenu na znaku.";
                    dug2.Text = "Vozilima čija ukupna visina ne premašuje visinu označenu na znaku.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z50";
                    break;

                case 11:
                    pitanje.Text = "Koje značenje ima ovaj saobraćajni znak?";
                    dug1.Text = "Obavezni smjerovi.";
                    dug2.Text = "Dozvoljeni smjerovi.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z51";
                    break;

                case 12:
                    pitanje.Text = "Koje značenje ima ovaj saobraćajni znak?";
                    dug1.Text = "Najmanja dozvoljena brzina.";
                    dug2.Text = "Najveća dozvoljena brzina.";
                    dug3.Text = "Brzina koja se preporučuje na određenom dijelu puta.";
                    dug3.IsVisible = true;

                    dug3.TabIndex = 1;
                    Tacanodg = dug3.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z52";
                    break;

                case 13:
                    pitanje.Text = "Koje značenje ima ovaj saobraćajni znak?";
                    dug1.Text = "Početak autoputa.";
                    dug2.Text = "Početak brzog puta.";
                    dug3.Text = "Početak puta rezervisanog za saobraćaj motornih vozila.";
                    dug3.IsVisible = true;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z53";
                    break;

                case 14:
                    pitanje.Text = "Kako treba postupiti nailaskom na ovaj saobraćajni znak? (2 tačna odgovora)";
                    dug1.Text = "Povećati brzinu kretanja vozila.";
                    dug2.Text = "Smanjiti brzinu kretanja vozila.";
                    dug3.Text = "Računati na mogućnost udara bočnog vjetra sa desne strane.";
                    dug3.IsVisible = true;

                    dug2.TabIndex = 1;
                    dug3.TabIndex = 1;
                    brojTacnihOdg = 2;
                    Tacanodg = dug2.Text + "' i '" + dug3.Text;
                    slikapit.Source = "z54";
                    break;

                case 15:
                    pitanje.Text = "Koje značenje imaj ovaj saobraćajni znak?";
                    dug1.Text = "Obavezno zaustaviti vozilo.";
                    dug2.Text = "Nailazak na raskrsnicu regulisanu svjetlosnom saobraćajnom signalizacijom.";
                    dug3.Text = "Nastaviti kretanje vozilom bez smanjenja brzine kretanja.";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z55";
                    break;

                case 16:
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
                    break;

                case 17:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je:";
                    dug1.Text = "Zabrana polukružnog okretanja.";
                    dug2.Text = "Obavezno polukružno okretanje.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z57";
                    break;

                case 18:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je?";
                    dug1.Text = "Zabrana saobraćaja za vozila koja prevoze opasne materije.";
                    dug2.Text = "Zabrana saobraćaja za vozila cisterne.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z58";
                    break;

                case 19:
                    pitanje.Text = "Tačan naziv saobraćajnog znaka je?";
                    dug1.Text = "Zabrana saobraćaja za sva motorna vozila koja vuku priključno vozilo.";
                    dug2.Text = "Zabrana saobraćaja za teretno vozilo koje vuče priključno vozilo.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z59";
                    break;

                case 20:
                    pitanje.Text = "Koje značenje ima ovaj saobraćajni znak?";
                    dug1.Text = "Obavezan smjer.";
                    dug2.Text = "Obavezno polukružno okretanje.";
                    dug3.Text = "";
                    dug3.IsVisible = false;

                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "z60";
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