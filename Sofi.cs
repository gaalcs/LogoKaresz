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

        void virag_nagy(double meret, Color szin_szirom, Color szin_kozep,  Color szin_background)
        {
            for (int i = 0; i < 8; i++)
            {
                Tollat(fel);
                Előre(meret);
                Tollat(le);

                kor(meret/2, szin_szirom);

                Tollat(fel);
                Hátra(meret);
                Tollat(le);

                Jobbra(45);
            }

            //background szin

            Tollat(fel);
            Balra(90);
            Előre(meret);
            Jobbra(90);
            Tollat(le);

            kor(meret, szin_background);

            Tollszín(szin_background);
            Jobbra(90);
            Előre(meret);
            Balra(90);
            Odatolt(0, meret / 2, szin_background);
            Odatolt(0,meret*0.75,szin_background);

            //masodik belso kor

            Tollat(fel);
            Balra(90);
            Előre(meret*0.60);
            Jobbra(90);
            Tollat(le);

            kor(meret*0.60, szin_kozep);

            Tollszín(szin_kozep);
            Jobbra(90);
            Előre(meret*0.60);
            Balra(90);
            Odatolt(0, meret/8, szin_kozep);
            //Odatolt(0, meret / 3, szin_background);


        }
    }
}