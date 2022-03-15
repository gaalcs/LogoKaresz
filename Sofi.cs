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
            kor(meret);
            Odatolt(90, meret, szin);
            Tollszín(Color.Black);
        }

        void Odatolt(double szog, double hossz, Color szin)
        {
            Tollat(fel);
            Jobbra(szog);
            Előre(hossz);
            Tölt(szin, false);
            Hátra(hossz);
            Balra(szog);
            Tollat(le);
        }

        void virag_kicsi(double meret, Color szin_szirom, Color szin_kozep)
        {

            for (int i = 0; i < 6; i++)
            {
                Tollat(fel);
                Előre(meret / 2);
                Tollat(le);

                kor(meret / 2, szin_szirom);

                Tollat(fel);
                Hátra(meret / 2);
                Tollat(le);

                Jobbra(60);
            }


            Tollat(fel);
            Balra(90);
            Előre(meret * 0.60);
            Jobbra(90);
            Tollat(le);

            kor(meret * 0.60, szin_kozep);

            Tollszín(szin_kozep);
            Jobbra(90);
            Előre(meret * 0.60);
            Balra(90);
            Odatolt(0, meret / 2, szin_kozep);
        }

        void virag_nagy(double meret, Color szin_szirom, Color szin_kozep, Color szin_background)
        {
            for (int i = 0; i < 8; i++)
            {
                Tollat(fel);
                Előre(meret);
                Tollat(le);

                kor(meret / 2, szin_szirom);

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
            Odatolt(0, meret * 0.75, szin_background);

            //masodik belso kor

            Tollat(fel);
            Balra(90);
            Előre(meret * 0.60);
            Jobbra(90);
            Tollat(le);

            kor(meret * 0.60, szin_kozep);

            Tollszín(szin_kozep);
            Jobbra(90);
            Előre(meret * 0.60);
            Balra(90);
            Odatolt(0, meret / 8, szin_kozep);
        }
        /// <summary>
        /// a vaza feher szele, merettel szorzod az alap (300-as) meretet
        /// </summary>
        /// <param name="meret"> ennyivel osztod az alap (300-as) meretet</param>
        void vaza_szele_balra(double meret, Color szin)
        {
            Tollszín(szin);
            Bezier(0, 45 * meret, 210 * meret, 0, 300 * meret);
            Balra(90 + 45 * meret);
            Előre(300 * meret / 6);
            Balra(90);
            Bezier(0, -45 * meret, -210 * meret, 0, 300 * meret);
            Balra(90 - 45 * meret);
            Előre(300 * meret / 6);
            Balra(90);
            Odatolt(-75, meret * 10, szin);
            Tollszín(Color.Black);
        }
        void vaza_szele_jobbra(double meret, Color szin)
        {
            Tollszín(szin);
            Bezier(0, -45 * meret, 210 * meret, 0, 300 * meret);
            Jobbra(90 + 45 * meret);
            Előre(300 * meret / 6);
            Jobbra(90);
            Bezier(0, 45 * meret, -210 * meret, 0, 300 * meret);
            Jobbra(90 - 45 * meret);
            Előre(300 * meret / 6);
            Jobbra(90);
            Odatolt(75, meret * 10, szin);
            Tollszín(Color.Black);
        }
        /// <summary>
        /// a meret azt hatarozza meg hogy az alap meretet mennyivel szorzod meg.
        /// </summary>
        /// <param name="meret"></param>
        /// <param name="szin_kulso"></param>
        /// <param name="szin_belso"></param>
        void tolcser_virag_baloldali(double meret, Color szin_kulso, Color szin_belso, Color kor_szin)
        {
            #region a virag bal kulso szirma
            Tollszín(szin_kulso);
            Balra((90 + 45));
            Bezier(meret * 4.5 / 10, 90, meret * -3.5 / 10, 75, meret);
            //vissza megy a kezdő pontba & megrajzolja a belso ivet is
            Tollat(fel);
            Balra(15);
            Hátra(meret);
            Jobbra(15);
            Előre(meret / 10);
            Jobbra(45);
            Tollat(le);
            Balra((90 + 45));
            Bezier(meret * 3.5 / 10, 70, meret * -4.25 / 10, 73, meret - meret / 10);
            // vissza a kezdőpontba
            Tollat(fel);
            Jobbra(5);
            Hátra(meret);
            Jobbra(15);
            Jobbra(45);
            Tollat(le);

            #endregion

            #region jobb kulso szirom
            Jobbra(45);
            Bezier(meret * 4.5 / 10, 0, meret * 3.5 / 10, -75, meret);
            Tollat(fel);
            Balra(75);
            Hátra(meret);
            Balra(15);
            Előre(meret / 10);
            Tollat(le);
            Jobbra(90);
            Bezier(meret * 3.5 / 10, 20, meret * 4.25 / 10, -73, meret - meret / 10);
            // vissza a kezdőpontba
            Tollat(fel);
            Balra(95);
            Hátra(meret);
            Jobbra(15 * 2);

            Tollat(le);

            #endregion


            Odatolt(0, meret / 5, szin_kulso);

            #region belso resz

            Tollszín(szin_belso);
            Tollat(fel);
            Balra(45);
            Előre(meret / 7);
            Balra(90);
            Tollat(le);

            Bezier(meret * 2 / 10, 90, meret * -2.5 / 10, 80, meret - meret / 7);

            //hatra
            Tollat(fel);
            Balra(10);
            Hátra(meret - meret / 7);
            Jobbra(10);
            Tollat(le);

            //masik oldal
            Jobbra(90);
            Bezier(meret * 2 / 10, 0, meret * 2.5 / 10, -80, meret - meret / 7);

            Balra(180);
            Bezier(meret * 1.5 / 10, -45, 0, -35, (meret - meret / 8) / 5);

            Jobbra(100);
            Bezier(meret * 1.5 / 10, -90, 0, -22, (meret - meret / 10) / 5);
            #endregion

            Odatolt(-80, meret / 3, szin_belso);
            Tollat(fel);
            Hátra(meret / 5);
            Tollat(le);

            kor(meret*0.05, kor_szin);

        }
        void tolcser_virag_jobboldali(double meret, Color szin_kulso, Color szin_belso, Color kor_szin)
        {
            #region a virag bal kulso szirma
            Tollszín(szin_kulso);
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

            Bezier(meret * 3.5 / 10, 110, meret * 4.25 / 10, -73, meret - meret / 10);
            // vissza a kezdőpontba
            Tollat(fel);
            Balra(5);
            Előre(meret);
            Jobbra(5);
            Jobbra(70);
            Tollat(le);

            #endregion


            #region jobb kulso szirom

            Hátra(meret/50); 
            Bezier(meret * 4.5 / 10, 180, meret * -3.5 / 10, 75, meret);

            Tollat(fel);
            Balra(75);
            Balra(30); Hátra(meret);
            Jobbra(15);
            Előre(meret / 10);
            Tollat(le);

            Balra(90);
            Bezier(meret * 3.5 / 10, 160, meret * -4.25 / 10, 73, meret - meret / 10);
            // vissza a kezdőpontba

            Tollat(fel);
            Balra(85);
            Hátra(meret);
            Jobbra(15);

            Tollat(le);

            #endregion
            Odatolt(0, meret / 15, szin_kulso);

            #region belso resz

            Tollszín(szin_belso);
            Tollat(fel);

            Előre(meret / 7);
            Balra(90);

            Tollat(le);

            Bezier(meret * 2 / 10, 180, meret * -2.5 / 10, 80, meret - meret / 7);

            //hatra
            Tollat(fel);
            Balra(90);
            Balra(10);
            Hátra(meret - meret / 7);
            Jobbra(10);
            Tollat(le);

            //masik oldal
            Jobbra(90);

            Bezier(meret * 2 / 10, -30, meret * -2.5 / 10, -80, meret - meret / 7);

            Balra(135);
            Bezier(meret * 1.5 / 10, -45, 0, -35, (meret - meret / 8) / 5);

            Jobbra(70);
            Bezier(meret * 1.5 / 10, -90, 0, -22, (meret - meret / 10) / 5);
            #endregion


            Odatolt(-80, meret / 3, szin_belso);

            Tollat(fel);
            Jobbra(20);
            Hátra(meret / 5);
            Tollat(le);

            kor(meret*0.05, kor_szin);

        }
        void tolcser_virag_kozepre(double meret, Color szin_kulso, Color szin_belso, Color kor_szin)
        {
            #region a virag bal kulso szirma
            Tollszín(szin_kulso);
            Balra((90));
            Bezier(meret * 4.5 / 10, 135, meret * -3.5 / 10, 75, meret);
            //vissza megy a kezdő pontba & megrajzolja a belso ivet is
            Tollat(fel);
            Balra(60);
            Hátra(meret);
            Jobbra(15);
            Előre(meret / 10);
            Tollat(le);
            Balra(90);

            Bezier(meret * 3.5 / 10, 115, meret * -4.25 / 10, 73, meret - meret / 10);


            // vissza a kezdőpontba

            Tollat(fel);
            Balra(40);
            Hátra(meret);
            Jobbra(15);
            Tollat(le);
            #endregion

            #region blah
            Jobbra(90);
            Bezier(meret * 4.5 / 10, 45, meret * 3.5 / 10, -75, meret);

            Tollat(fel);
            Balra(105);
            Balra(15);
            Hátra(meret);
            Balra(15);
            Előre(meret / 10);
            Tollat(le);

            Jobbra(90);

            Bezier(meret * 3.5 / 10, -110, meret * -4.25 / 10, -73, meret - meret / 10);

            // vissza a kezdőpontba

            Tollat(fel);
            Jobbra(35);
            Hátra(meret);
            Balra(15);

            Tollat(le);
            #endregion

            Odatolt(0, meret / 15, szin_kulso); 
            #region belso resz

            Tollszín(szin_belso);
            Tollat(fel);

            Előre(meret / 7);
            Balra(90);

            Tollat(le);

            Bezier(meret * 2 / 10, 135, meret * -2.5 / 10, 80, meret - meret / 7);

            //hatra
            Tollat(fel);
            Balra(45);
            Balra(10);
            Hátra(meret - meret / 7);
            Jobbra(10);
            Tollat(le);

            //masik oldal
            Jobbra(90);

            Bezier(meret * 2 / 10, -135, meret * -2.5 / 10, -80, meret - meret / 7);

            Balra(45);
            Bezier(meret * 1.5 / 10, -45, 0, -35, (meret - meret / 8) / 5);

            Jobbra(70 + 30);
            Bezier(meret * 1.5 / 10, -90, 0, -22, (meret - meret / 10) / 5);
            #endregion

            Odatolt(-80, meret / 3, szin_belso);
        }

        void tolcser_viragok(double meret, Color szin_kulso, Color szin_belso, Color kor_szin) //!!!
        {
            tolcser_virag_kozepre(meret, szin_kulso, szin_belso, kor_szin);
            Tollszín(Color.Black);
            Tollat(fel);
            Jobbra(90 + 27);
            Hátra(meret);
            Jobbra(8);


            Balra(90);
            Előre(meret / 3);
            Jobbra(90);
            Előre(meret / 6);
            Tollat(le);

            tolcser_virag_baloldali(meret, szin_kulso, szin_belso, kor_szin);

            Tollat(fel);
            Előre(meret / 5);
            Jobbra(115);
            Hátra(meret);
            Jobbra(55);

            Jobbra(90);
            Előre(meret / 1.5);
            Balra(90);
            Tollat(le);

            tolcser_virag_jobboldali(meret, szin_kulso, szin_belso, kor_szin);
            Tollat(fel);

            Előre(meret / 5);
            Jobbra(110);
            Hátra(meret);
            Balra(35);

            Balra(90);
            Előre(meret / 3);
            Jobbra(90);
            Hátra(meret / 6);
            Tollat(le);


        }

    }
}