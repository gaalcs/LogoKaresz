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
            Ív(360, meret);
        }
        void kor(double meret, Color szin)
        {
            Tollszín(szin);
            Ív(360, meret);
            Odatolt(90, meret, szin);
            Tollszín(Color.Black);
        }

        void Odatolt(double szog, double hossz, Color szin)
        {
            Tollat(fel);
            Jobbra(szog);
            Előre(hossz);
            Tölt(szin,false);
            Hátra(hossz);
            Balra(szog);
            Tollat(le);
        }

        void virag_kicsi(double meret, Color szin_szirom, Color szin_kozep)
        {
            
            for (int i = 0; i < 6; i++)
            {
                Tollat(fel);
                Előre(meret/2);
                Tollat(le);
                   
                kor(meret / 2, szin_szirom);

                Tollat(fel);
                Hátra(meret/2);
                Tollat(le);

                Jobbra(60);
            }


            Tollat(fel);
            Balra(90);
            Előre(meret * 0.60);
            Jobbra(90);
            Tollat(le);

            kor(meret*0.60,szin_kozep);

            Tollszín(szin_kozep);
            Jobbra(90);
            Előre(meret*0.60);
            Balra(90);
            Odatolt(0,meret/2,szin_kozep);
        }
    }
}