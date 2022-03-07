using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
    public partial class Form1 : Form
    {
        /* Függvények */


        /* Függvények vége */
        void FELADAT()
        {
            double meret = 200;
            /* Ezt indítja a START gomb! */
            // Teleport(közép.X, közép.Y+150, észak);
            //tolcser_virag_baloldali(meret,Color.Red,Color.Blue,Color.Yellow);
            
            Jobbra((90 + 45));
            Bezier(meret * 4.5 / 10, 90, meret * 3.5 / 10, -75, meret);
            //vissza megy a kezdő pontba & megrajzolja a belso ivet is
            Tollat(fel);
            Jobbra(15);
            Előre(meret);
            Balra(15);
            Hátra(meret / 10);
            Balra(90); 
            Tollat(le);
            
            Bezier(meret * 3.5 / 10, 90, meret * 4.25 / 10, -73, meret - meret / 10);
            // vissza a kezdőpontba
            Tollat(fel);
            Jobbra(15);
            Előre(meret);
            Jobbra(5);
            Jobbra(70);
            Tollat(le);
        }
    }
}
