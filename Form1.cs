﻿using System;
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
            double meret = 300;
            /* Ezt indítja a START gomb! */
            // Teleport(közép.X, közép.Y+150, észak);
            tolcser_virag_baloldali(meret,Color.Red,Color.Blue,Color.Yellow);

            

        }
    }
}
