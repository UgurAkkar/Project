using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mini_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Cards[] kaarten = new Cards[53];
        Random rndKaarten = new Random();
        int counter = 0;
        int comp, play,gelijk;
        public MainWindow()
        {
            InitializeComponent();



        }

        private void btnShuffle_Click(object sender, RoutedEventArgs e)
        {
            maakKaarten();
            clear();

        }

        private void btnDealCards_Click(object sender, RoutedEventArgs e)
        {
            DealCards();
        }

        public void maakKaarten()
        {
            for (int i = 0; i < 13; i++)
            {
                kaarten[i] = new Cards("Hearts", Convert.ToString(i), false, i);

            }
            for (int i = 0; i < 13; i++)
            {
                kaarten[i + 13] = new Cards("Spades", Convert.ToString(i), false, i);

            }
            for (int i = 0; i < 13; i++)
            {
                kaarten[i + 26] = new Cards("Diamonds", Convert.ToString(i), false, i);

            }
            for (int i = 0; i < 13; i++)
            {
                kaarten[i + 39] = new Cards("Clubs", Convert.ToString(i), false, i);

            }
        }

        public void DealCards()
        {
            int rnd1 = rndKaarten.Next(52);
            int rnd2 = rndKaarten.Next(52);


            if (AllesUitgedeeld() == false)
            {
                if (kaarten[(rnd1)].Used == true)
                {
                    do
                    {
                        rnd1 = rndKaarten.Next(52);
                    } while (kaarten[rnd1].Used == true);

                    lblComp.Content = kaarten[(rnd1)].Value + " of " + kaarten[(rnd1)].Suits;
                    BitmapImage image = new BitmapImage(new Uri("\\images\\" + Convert.ToString(kaarten[(rnd1)].Value + kaarten[(rnd1)].Suits) + ".png", UriKind.Relative));
                    imgComp2.Source = image;
                    kaarten[rnd1].Used = true;



                }
                else
                {
                    lblComp.Content = kaarten[(rnd1)].Value + " of " + kaarten[(rnd1)].Suits;
                    BitmapImage image = new BitmapImage(new Uri("\\images\\" + Convert.ToString(kaarten[(rnd1)].Value + kaarten[(rnd1)].Suits) + ".png", UriKind.Relative));
                    imgComp2.Source = image;

                    kaarten[rnd1].Used = true;
                }

                if (kaarten[(rnd2)].Used == true)
                {
                    do
                    {
                        rnd2 = rndKaarten.Next(52);
                    } while (kaarten[rnd2].Used == true);

                    lblPlay.Content = kaarten[(rnd2)].Value + " of " + kaarten[(rnd2)].Suits;
                    BitmapImage image = new BitmapImage(new Uri("\\images\\" + Convert.ToString(kaarten[(rnd2)].Value + kaarten[(rnd2)].Suits) + ".png", UriKind.Relative));
                    imgPlay2.Source = image;

                    kaarten[rnd2].Used = true;
                }
                else
                {
                    lblPlay.Content = kaarten[(rnd2)].Value + " of " + kaarten[(rnd2)].Suits;
                    BitmapImage image = new BitmapImage(new Uri("\\images\\" + Convert.ToString(kaarten[(rnd2)].Value + kaarten[(rnd2)].Suits) + ".png", UriKind.Relative));
                    imgPlay2.Source = image;

                    kaarten[rnd2].Used = true;
                }

                results(rnd1, rnd2);

            }

        }

        public void clear()
        {
            counter = 0;
            btnDealCards.IsEnabled = true;
            BitmapImage image = new BitmapImage(new Uri(@"\images\cardback.png", UriKind.Relative));
            imgComp1.Source = image;
            imgPlay1.Source = image;
            lblshuffeld.Content = "SHUFFELD";
            imgComp2.Source = null;
            imgPlay2.Source = null;
            txtResult.Text = null;
            comp = 0;
            play = 0;
            gelijk = 0;

        }

        public bool AllesUitgedeeld()
        {

            if (counter != 26)
            {
                counter++;
                return false;

            }
            else
            {
                lblshuffeld.Content = "Handed Out!";
                txtResult.Text = "Computer: " + comp + " Player: " + play;
                lbltie.Content = "Tie: " + gelijk;
                btnDealCards.IsEnabled = false;
                return true;
            }

        }

        public void results(int rnd1, int rnd2)
        {
            if (kaarten[rnd1].Waarde > kaarten[rnd2].Waarde)
            {
                comp++;
            }
            else if (kaarten[rnd1].Waarde == kaarten[rnd2].Waarde)
            {
                gelijk++;
            }
            else if (kaarten[rnd1].Waarde < kaarten[rnd2].Waarde)
            {
                play++;
            }

        }
    }
}
