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
            double meret = 70;
            Color szin = Color.Green;
            /* Ezt indítja a START gomb! */
            // Teleport(közép.X, közép.Y+150, észak);

            leveles_ag_jobb(meret,Color.Orange,Color.Yellow,Color.White);

        }
    }
}
