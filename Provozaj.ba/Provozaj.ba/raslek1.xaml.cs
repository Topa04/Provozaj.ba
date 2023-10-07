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
    public partial class raslek1 : ContentPage
    {
        List<int> brojPitanja = new List<int> {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22};

        int t = 0;
        int n = 0;
        int brPitanja = 0;
        int i;
        int rezultat;
        int brojTacnihOdg = 0;
        String Tacanodg = "";
        public raslek1()
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
            BrPit.Text = (brPitanja+1).ToString()+"/"+brojPitanja.Count();
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
                    pitanje.Text = "U saobraćajnoj situaciji kao na slici kojom putanjom vozač motocikla mora izvršiti radnju skretanja ulijevo ? ";
                    dug1.Text = "Putanjom broj 2.";
                    dug2.Text = "Putanjom broj 1.";
                    dug3.Text = "";
                    dug3.IsVisible = false;
                    
                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r1";
                    break;
                case 2:
                    pitanje.Text = "Koji je redoslijed prolaska na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "2 - 3 - 1";
                    dug2.Text = "2 - 1 - 3";
                    dug3.Text = "1 - 3 - 2";
                    dug3.IsVisible = true;
                    dug3.TabIndex = 1;
                    Tacanodg = dug3.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r2";
                    break;
                case 3:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "1 - 2";
                    dug2.Text = "2 - 1";
                    dug3.Text = "odg 3.";
                    dug3.IsVisible = false;
                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r3";
                    break;
                case 4:
                    pitanje.Text = "Kako u saobraćajnoj situaciji kao na slici mora postupiti vozač vozila broj 1:";
                    dug1.Text = "Propustiti vozilo broj 3, a zatim proći prije vozila broj 2.";
                    dug2.Text = "Propustiti vozilo broj 3, zatim propustiti vozilo broj 2 i zadnji proći kroz raskrsnicu.";
                    dug3.Text = "odg 3.";
                    dug3.IsVisible = false;
                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r4";
                    break;
                case 5:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "2 – 3 – 4 – 1";
                    dug2.Text = "2 – 3 – 1 – 4";
                    dug3.Text = "1 – 2 – 3 – 4";
                    dug3.IsVisible = true;
                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r5";
                    break;
                case 6:
                    pitanje.Text = "Kako u saobraćajnoj situaciji kao na slici mora postupiti vozač vozila broj 1?";
                    dug1.Text = "Proći kroz raskrsnicu prije vozila broj 2, a propustiti vozilo broj 3.";
                    dug2.Text = "Propustiti vozilo broj 2, a zatim proći kroz raskrsnicu prije vozila broj 3.";
                    dug3.Text = "odg 3.";
                    dug3.IsVisible = false;
                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r6";
                    break;
                case 7:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "3 – 1 – 2 – 4";
                    dug2.Text = "4 – 2 – 1 – 3";
                    dug3.Text = "3 – 4 – 2 – 1";
                    dug3.IsVisible = true;
                    dug3.TabIndex = 1;
                    Tacanodg = dug3.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r7";
                    break;
                case 8:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "2 – 3 – 1";
                    dug2.Text = "2 – 1 – 3";
                    dug3.Text = "3 – 1 – 2";
                    dug3.IsVisible = true;
                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r8";
                    break;
                case 9:
                    pitanje.Text = "Da li je u saobraćajnoj situaciji kao na slici dozvoljeno izvršiti radnju polukružnog okretanja vozilom?";
                    dug1.Text = "Da.";
                    dug2.Text = "Ne.";
                    dug3.Text = "odg 3.";
                    dug3.IsVisible = false;
                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r9";
                    break;
                case 10:
                    pitanje.Text = "U saobraćajnoj situaciji kao na slici, koji učesnik u saobraćaju mora sačekati i propustiti drugog učesnika ? ";
                    dug1.Text = "Broj 2.";
                    dug2.Text = "Broj 1.";
                    dug3.Text = "odg 3.";
                    dug3.IsVisible = false;
                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r10";
                    break;
                case 11:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "5 – 4 – 3 – 2 – 1";
                    dug2.Text = "1 – 2 – 3 – 4 – 5";
                    dug3.Text = "odg 3.";
                    dug3.IsVisible = false;
                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r11";
                    break;
                case 12:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "2 – 3 – 1";
                    dug2.Text = "1 – 2 – 3";
                    dug3.Text = "3 – 1 – 2";
                    dug3.IsVisible = true;
                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r12";
                    break;
                case 13:
                    pitanje.Text = "Kojim vozilima u saobraćajnoj situaciji kao na slici nije dozvoljen prolaz na raskrsnici?";
                    dug1.Text = "Vozilo broj 1 i broj 3.";
                    dug2.Text = "Vozilo broj 4 i broj 2.";
                    dug3.Text = "odg 3.";
                    dug3.IsVisible = false;
                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r13";
                    break;
                case 14:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "4 – 3 – 1 – 2";
                    dug2.Text = "3 – 4 – 1 – 2";
                    dug3.Text = "4 – 3 – 2 – 1";
                    dug3.IsVisible = true;
                    dug1.TabIndex = 1;
                    Tacanodg = dug1.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r14";
                    break;
                case 15:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "";
                    dug2.Text = "";
                    dug3.Text = "";
                    dug3.IsVisible = true;
                    dug3.TabIndex = 1;
                    Tacanodg = dug3.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r15";
                    break;
                case 16:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "2 – 3 – 1";
                    dug2.Text = "2 – 3 – 1";
                    dug3.Text = "1 – 3 – 2";
                    dug3.IsVisible = true;
                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r16";
                    break;
                case 17:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "1 – 2 – 3";
                    dug2.Text = "3 – 2 – 1";
                    dug3.Text = "2 – 1 – 3";
                    dug3.IsVisible = true;
                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r17";
                    break;
                case 18:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "1 – 3 – 2";
                    dug2.Text = "2 – 3 – 1";
                    dug3.Text = "2 – 1 – 3";
                    dug3.IsVisible = true;
                    dug3.TabIndex = 1;
                    Tacanodg = dug3.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r18";
                    break;
                case 19:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "1 – 3 – 2 – 4";
                    dug2.Text = "3 – 2 – 1 – 4";
                    dug3.Text = "3 – 1 – 2 – 4";
                    dug3.IsVisible = true;
                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r19";
                    break;
                case 20:
                    pitanje.Text = "Kako u saobraćajnoj situaciji kao na slici mora postupiti vozač vozila broj 2:";
                    dug1.Text = "Zaustaviti se i propustiti vozilo broj 1.";
                    dug2.Text = "Proći prije vozila broj 1.";
                    dug3.Text = "odg 3.";
                    dug3.IsVisible = false;
                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    brojTacnihOdg = 1;
                    slikapit.Source = "r20";
                    break;
                case 21:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "2 – 1 – 3";
                    dug2.Text = "2 – 1 – 3";
                    dug3.Text = "1 – 2 – 3";
                    dug3.IsVisible = true;
                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    slikapit.Source = "r21";
                    break;
                case 22:
                    pitanje.Text = "Koji je redoslijed prolaska vozila na raskrsnici u situaciji kao na slici?";
                    dug1.Text = "1 – 2 – 3";
                    dug2.Text = "1 – 3 – 2";
                    dug3.Text = "3 – 1 – 2";
                    dug3.IsVisible = true;
                    dug2.TabIndex = 1;
                    Tacanodg = dug2.Text;
                    slikapit.Source = "r22";
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