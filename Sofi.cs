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
                Tollszín(szin_szirom);
                Előre(meret/5);
                kor(meret / 3, szin_szirom);
                Tollszín(szin_szirom);
                Hátra(meret/5);
                Jobbra(60);
                
            }   
            Tollszín(Color.Black);                    

        }
    }
}