using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
using System;
using Microsoft.CSharp;


namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /**********************************************
         * ********************************************
         * ********************************************
         * ********************************************
         CALCUL PARFUM
         CALCUL PARFUM
         CALCUL PARFUM
         * ********************************************
         * ********************************************
         * ********************************************
         * *******************************************/

        int lvlParfum = 0;
        int rParfum = 0;
        int amountParfum = 0;

        public int Calcul_Parfum(int lvlParfum, int rParfum)
        {
            int amountParfum = 0;

            //lvl 1 - 24
            if (lvlParfum == 0)
            {
                if (rParfum == 0 || rParfum == 1 || rParfum == 2 || rParfum == 3 || rParfum == 4 || rParfum == 5 || rParfum == 6 || rParfum == 7)
                {
                    amountParfum = 0;
                }

            }


            //lvl 25-39
            else if (rParfum == 1)
            {
                if (rParfum == 0 || rParfum == 1 || rParfum == 2 || rParfum == 3 || rParfum == 4 || rParfum == 7)
                    amountParfum = 0;
            }

            else if (lvlParfum == 1 && rParfum == 5)
            {
                amountParfum = 5;
            }

            else if (lvlParfum == 1 && rParfum == 6)
            {
                amountParfum = 10;
            }

            //lvl 40-49
            else if (lvlParfum == 2)
            {
                if (rParfum == 1 || rParfum == 7 || rParfum == 0)
                {
                    amountParfum = 0;
                }
                else if (lvlParfum == 2 && rParfum == 2) amountParfum = 5;
                else if (lvlParfum == 2 && rParfum == 3) amountParfum = 5;
                else if (lvlParfum == 2 && rParfum == 4) amountParfum = 10;
                else if (lvlParfum == 2 && rParfum == 5) amountParfum = 20;
                else if (lvlParfum == 2 && rParfum == 6) amountParfum = 40;
            }
            //lvl 50-59

            else if (lvlParfum == 3)
            {
                if (rParfum == 0 || rParfum == 7)
                {
                    amountParfum = 0;
                }
                else if (lvlParfum == 3 && rParfum == 1) amountParfum = 5;
                else if (lvlParfum == 3 && rParfum == 2) amountParfum = 10;
                else if (lvlParfum == 3 && rParfum == 3) amountParfum = 10;
                else if (lvlParfum == 3 && rParfum == 4) amountParfum = 20;
                else if (lvlParfum == 3 && rParfum == 5) amountParfum = 40;
                else if (lvlParfum == 3 && rParfum == 6) amountParfum = 80;
            }

            //lvl 60-69
            else if (lvlParfum == 4)
            {
                if (rParfum == 7)
                {
                    amountParfum = 0;
                }
                else if (lvlParfum == 4 && rParfum == 0) amountParfum = 5;
                else if (lvlParfum == 4 && rParfum == 1) amountParfum = 10;
                else if (lvlParfum == 4 && rParfum == 2) amountParfum = 10;
                else if (lvlParfum == 4 && rParfum == 3) amountParfum = 20;
                else if (lvlParfum == 4 && rParfum == 4) amountParfum = 40;
                else if (lvlParfum == 4 && rParfum == 5) amountParfum = 80;
                else if (lvlParfum == 4 && rParfum == 6) amountParfum = 120;
            }

            //lvl 70-79
            else if (lvlParfum == 5)
            {
                if (rParfum == 7)
                {
                    amountParfum = 0;
                }
                else if (lvlParfum == 5 && rParfum == 0) amountParfum = 10;
                else if (lvlParfum == 5 && rParfum == 1) amountParfum = 10;
                else if (lvlParfum == 5 && rParfum == 2) amountParfum = 20;
                else if (lvlParfum == 5 && rParfum == 3) amountParfum = 40;
                else if (lvlParfum == 5 && rParfum == 4) amountParfum = 80;
                else if (lvlParfum == 5 && rParfum == 5) amountParfum = 120;
                else if (lvlParfum == 5 && rParfum == 6) amountParfum = 160;
            }

            //lvl 80-89
            else if (lvlParfum == 6)
            {
                if (rParfum == 7)
                {
                    amountParfum = 0;
                }
                else if (lvlParfum == 6 && rParfum == 0) amountParfum = 10;
                else if (lvlParfum == 6 && rParfum == 1) amountParfum = 20;
                else if (lvlParfum == 6 && rParfum == 2) amountParfum = 40;
                else if (lvlParfum == 6 && rParfum == 3) amountParfum = 80;
                else if (lvlParfum == 6 && rParfum == 4) amountParfum = 120;
                else if (lvlParfum == 6 && rParfum == 5) amountParfum = 160;
                else if (lvlParfum == 6 && rParfum == 6) amountParfum = 200;
            }

            //lvl 90-99
            else if (lvlParfum == 7)
            {
                if (rParfum == 7)
                {
                    amountParfum = 0;
                }
                else if (lvlParfum == 7 && rParfum == 0) amountParfum = 20;
                else if (lvlParfum == 7 && rParfum == 1) amountParfum = 40;
                else if (lvlParfum == 7 && rParfum == 2) amountParfum = 80;
                else if (lvlParfum == 7 && rParfum == 3) amountParfum = 120;
                else if (lvlParfum == 7 && rParfum == 4) amountParfum = 160;
                else if (lvlParfum == 7 && rParfum == 5) amountParfum = 200;
                else if (lvlParfum == 7 && rParfum == 6) amountParfum = 300;
            }

            //lvl +25
            else if (lvlParfum == 8)
            {

                if (lvlParfum == 8 && rParfum == 0) amountParfum = 65;
                else if (lvlParfum == 8 && rParfum == 1) amountParfum = 105;
                else if (lvlParfum == 8 && rParfum == 2) amountParfum = 145;
                else if (lvlParfum == 8 && rParfum == 3) amountParfum = 185;
                else if (lvlParfum == 8 && rParfum == 4) amountParfum = 225;
                else if (lvlParfum == 8 && rParfum == 5) amountParfum = 265;
                else if (lvlParfum == 8 && rParfum == 6) amountParfum = 305;
                else if (lvlParfum == 8 && rParfum == 7) amountParfum = 345;
            }

            //lvl +28
            else if (lvlParfum == 9)
            {

                if (lvlParfum == 9 && rParfum == 0) amountParfum = 68;
                else if (lvlParfum == 9 && rParfum == 1) amountParfum = 108;
                else if (lvlParfum == 9 && rParfum == 2) amountParfum = 148;
                else if (lvlParfum == 9 && rParfum == 3) amountParfum = 188;
                else if (lvlParfum == 9 && rParfum == 4) amountParfum = 228;
                else if (lvlParfum == 9 && rParfum == 5) amountParfum = 268;
                else if (lvlParfum == 9 && rParfum == 6) amountParfum = 308;
                else if (lvlParfum == 9 && rParfum == 7) amountParfum = 348;
            }

            //lvl +45 et +48

            else if (lvlParfum == 10 || lvlParfum == 11)
            {
                amountParfum = 999;
            }

            return amountParfum;
        }

        private void rare_parfum_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            rParfum = rare_parfum.SelectedIndex;
            amountParfum = Calcul_Parfum(lvlParfum, rParfum);
            
            nb_parfum.Text = Convert.ToString(amountParfum);
        }

        private void lvl_parfum_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lvlParfum = lvl_parfum.SelectedIndex;
            amountParfum = Calcul_Parfum(lvlParfum, rParfum);
            
            nb_parfum.Text = Convert.ToString(amountParfum);
        }



        /**********************************************
         * ********************************************
         * ********************************************
         * ********************************************
         PRESSE PAPIER
         PRESSE PAPIER
         PRESSE PAPIER
         * ********************************************
         * ********************************************
         * ********************************************
         * *******************************************/


        private void bpp1_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(pp1.Text);
        }

        private void bpp2_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(pp2.Text);
        }

        private void bpp3_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(pp3.Text);
        }

        private void bpp4_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(pp4.Text);
        }




        /**********************************************
         * ********************************************
         * ********************************************
         * ********************************************
         BENEF CRAFT
         BENEF CRAFT
         BENEF CRAFT
         * ********************************************
         * ********************************************
         * ********************************************
         * *******************************************/



        /**********************************************
         * ********************************************
         * ********************************************
         * ********************************************
         POINTS SP
         POINTS SP
         POINTS SP
         * ********************************************
         * ********************************************
         * ********************************************
         * *******************************************/



        /**********************************************
         * ********************************************
         * ********************************************
         * ********************************************
         BATEAU A4
         BATEAU A4
         BATEAU A4
         * ********************************************
         * ********************************************
         * ********************************************
         * *******************************************/


        /**********************************************
         * ********************************************
         * ********************************************
         * ********************************************
         RAPPELS
         RAPPELS
         RAPPELS
         * ********************************************
         * ********************************************
         * ********************************************
         * *******************************************/



    }

}
