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
            /* Ezt indítja a START gomb! */
            // Teleport(közép.X, közép.Y+150, észak);
            tolcser_virag_baloldali(100,Color.Red,Color.Blue);


            //Balra(90);
            //Bezier(100,0,100,45,150,true,true);
        }
    }
}
