using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
    partial class Form1
    {
        void kor(double meret)
        {
            Ív(360,meret);
        }

        void Odatolt(double szog, double hossz, Color szin)
        {
            Tollat(fel);
            Jobbra(szog);
            Előre(hossz);
            Tölt(szin);
            Hátra(hossz);
            Balra(szog);
            Tollat(le);
        }
    }
}