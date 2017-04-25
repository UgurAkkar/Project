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

        public MainWindow()
        {
            InitializeComponent();



        }

        private void btnShuffle_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                kaarten[i] = new Cards("Hearts", Convert.ToString(i), false);

            }
            for (int i = 0; i < 13; i++)
            {
                kaarten[i + 13] = new Cards("Spades", Convert.ToString(i), false);

            }
            for (int i = 0; i < 13; i++)
            {
                kaarten[i + 26] = new Cards("Diamonds", Convert.ToString(i), false);

            }
            for (int i = 0; i < 13; i++)
            {
                kaarten[i + 39] = new Cards("Clubs", Convert.ToString(i), false);

            }

            //BitmapImage cardback = new BitmapImage();
            //cardback.BeginInit();
            //cardback.UriSource = new Uri(@"Cards\cardback.png", UriKind.RelativeOrAbsolute);
            //cardback.EndInit();

            //BitmapImage image = new BitmapImage(new Uri("Cards/cardback.png", UriKind.Relative));

            //imgComp1.Source = image;

        }

        private void btnDealCards_Click(object sender, RoutedEventArgs e)
        {

            int rnd1 = rndKaarten.Next(52);
            int rnd2 = rndKaarten.Next(52);

            if (kaarten[(rnd1)].Used == true) {
                do
                {
                    rnd1 = rndKaarten.Next(52);
                } while (kaarten[rnd1].Used == true);

                lblComp.Content = kaarten[(rnd1)].Value + " of " + kaarten[(rnd1)].Suits;
                kaarten[rnd1].Used = true;

            }
            else
            {
                lblComp.Content = kaarten[(rnd1)].Value + " of " + kaarten[(rnd1)].Suits;
                kaarten[rnd1].Used = true;
            }

            if (kaarten[(rnd2)].Used == true)
            {
                do
                {
                    rnd2 = rndKaarten.Next(52);
                } while (kaarten[rnd2].Used == true);

                lblPlay.Content = kaarten[(rnd2)].Value + " of " + kaarten[(rnd2)].Suits;
                kaarten[rnd2].Used = true;
            }
            else
            {
                lblPlay.Content = kaarten[(rnd2)].Value + " of " + kaarten[(rnd2)].Suits;
                kaarten[rnd2].Used = true;
            }


            
        }
    }
}
