using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
        #region Függvények
        #region Zsófi
        #region Virágok
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
            Odatolt(45, meret / 2, szin_kozep);
            Jobbra(90);
            Előre(meret * 0.60);
            Balra(90);
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
        #endregion

        #region Váza széle
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
        #endregion

        #region Tölcsér virágok
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

            kor(meret * 0.05, kor_szin);
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
            Hátra(meret / 50);
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

            kor(meret * 0.05, kor_szin);
        }
        void tolcser_virag_kozepre(double meret, Color szin_kulso, Color szin_belso)
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
        void tolcser_viragok(double meret, Color szin_kulso, Color szin_belso, Color kor_szin)
        {
            tolcser_virag_kozepre(meret, szin_kulso, szin_belso);
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

        void tolcser_es_kicsi_viragok(double meret, Color szin_kulso, Color szin_belso, Color kor_szin)
        {
            tolcser_viragok(meret, szin_kulso, szin_belso, kor_szin);

            #region bal oldali kicsi virgok
            Tollat(fel);
            Balra(90);
            Előre(meret / 3);
            Jobbra(90);
            Előre(meret / 6);

            Balra(45);
            Előre(meret * 0.50);

            Balra(90);
            Előre(meret / 3);
            Tollat(le);

            virag_kicsi(meret / 15, szin_kulso, szin_belso);

            Tollat(fel);
            Hátra((meret / 3) * 2);
            Jobbra(180);
            Tollat(le);

            virag_kicsi(meret / 15, szin_kulso, szin_belso);

            Tollat(fel);

            Hátra((meret / 3));
            Balra(90);
            Hátra(meret * 0.50);

            Jobbra(45);

            Hátra(meret / 6);
            Balra(90);
            Hátra(meret / 3);
            Jobbra(90);

            Tollat(le);
            #endregion

            #region jobb oldali kicsi virgok
            Tollat(fel);
            Jobbra(90);
            Előre(meret / 3);
            Balra(90);
            Előre(meret / 6);

            Jobbra(45);
            Előre(meret * 0.50);

            Jobbra(90);
            Előre(meret / 3);
            Tollat(le);

            virag_kicsi(meret / 15, szin_kulso, szin_belso);

            Tollat(fel);
            Hátra((meret / 3) * 2);
            Jobbra(180);
            Tollat(le);

            virag_kicsi(meret / 15, szin_kulso, szin_belso);

            Tollat(fel);

            Hátra((meret / 3));
            Jobbra(90);
            Hátra(meret * 0.50);

            Balra(45);

            Hátra(meret / 6);
            Balra(-90);
            Hátra(meret / 3);
            Balra(90);

            Tollat(le);
            #endregion
        }
        #endregion

        #region Levelek
        void elso_baloldali_level(double meret, Color szin)
        {
            Tollszín(szin);
            Jobbra(45);

            Bezier_3_pontos(new Pont(meret * 0.20, meret * -2.70), new Pont(-meret * 2.50, -meret * 2.2), new Pont(-meret * 2.2, -meret * 0.50));
            Bezier_3_pontos(new Pont(meret * 0.20, 0), new Pont(meret * 1.10, 0), new Pont(meret * 1.60, meret * 1.60));
            Balra(28);
            Hátra(meret * 1.25);
            Balra(17);

            Odatolt(-90, meret * 0.10, szin);
            Tollszín(Color.Black);
        }
        void masodik_harmadik_baloldali_level(double meret, Color szin)
        {
            Tollszín(szin);
            Jobbra(45);

            Bezier_3_pontos(new Pont(meret * 1, meret * -3.10), new Pont(meret * -2.70, meret * -3.0), new Pont(meret * -2.10, meret * -1.0));
            Bezier_3_pontos(new Pont(meret * 0.20, 0), new Pont(meret * 1.20, meret * 0.20), new Pont(meret * 1.0, meret * 1.90));
            Balra(50);
            Hátra(meret * 1.45);
            Jobbra(50);

            Odatolt(-135, meret * 0.5, szin);
            Balra(45);

            Tollszín(Color.Black);
        }
        void elso_jobboldali_level(double meret, Color szin)
        {
            Tollszín(szin);
            Jobbra(-45);

            Bezier_3_pontos(new Pont(meret * -0.20, meret * -2.70), new Pont(meret * 2.50, -meret * 2.2), new Pont(meret * 2.2, -meret * 0.50));
            Bezier_3_pontos(new Pont(meret * -0.20, 0), new Pont(meret * -1.10, 0), new Pont(meret * -1.60, meret * 1.60));
            Balra(-28);
            Hátra(meret * 1.25);
            Balra(-17);

            Odatolt(90, meret * 0.10, szin);
            Tollszín(Color.Black);
        }
        void masodik_harmadik_jobboldali_level(double meret, Color szin)
        {
            Tollszín(szin);
            Jobbra(-45);

            Bezier_3_pontos(new Pont(meret * -1, meret * -3.10), new Pont(meret * 2.70, meret * -3.0), new Pont(meret * 2.10, meret * -1.0));
            Bezier_3_pontos(new Pont(meret * -0.20, 0), new Pont(meret * -1.20, meret * 0.20), new Pont(meret * -1.0, meret * 1.90));
            Balra(-50);
            Hátra(meret * 1.45);
            Jobbra(-50);

            Odatolt(135, meret * 0.50, szin);
            Balra(-45);

            Tollszín(Color.Black);
        }

        void baloldali_levelek(double meret, Color szin) //20as méret a megfelelő
        {
            elso_baloldali_level(meret * 1.25, szin);
            using (new Rajzol(false)) { Hátra(meret * 2.5); }
            masodik_harmadik_baloldali_level(meret, szin);
            Balra(15);
            using (new Rajzol(false)) { Hátra(meret * 2); }
            masodik_harmadik_baloldali_level(meret * 0.75, szin);
        }
        void jobboldali_levelek(double meret, Color szin)
        {
            elso_jobboldali_level(meret * 1.25, szin);
            using (new Rajzol(false)) { Hátra(meret * 2.5); }
            masodik_harmadik_jobboldali_level(meret, szin);
            Jobbra(15);
            using (new Rajzol(false)) { Hátra(meret * 2); }
            masodik_harmadik_jobboldali_level(meret * 0.75, szin);
        }
        #endregion
        #endregion

        #region Csabi
        #region Szele
        void Szele_hor_bal(double meret, int db, Color szin1, Color szin2, Color szin3)
        {
            for (int j = 0; j < db; j++)
            {
                #region korvonal
                Tollszín(szin1);
                Előre(meret * 8.68 / 10);
                Tollszín(Color.Black);
                Előre(meret * 1.32 / 10);
                Balra(90);
                for (int i = 0; i < 2; i++)
                {
                    Előre(meret);
                    Balra(90);
                }
                Előre(meret * 8.68 / 10);
                Tollszín(szin1);
                Előre(meret * 1.32 / 10);
                Tollszín(Color.Black);
                Balra(90);
                #endregion

                //helyezkedés a körre
                Tollat(fel);
                Balra(90);
                Előre(meret * 6.5 / 10);
                Jobbra(90);
                Előre(meret * 3.5 / 10);
                Hátra(meret / 7.5);
                Balra(90);
                Tollat(le);

                //kör
                Ív(360, meret / 7);

                Tollat(fel);
                Jobbra(90);
                Előre(meret / 15);
                Tölt(szin3);
                Hátra(meret / 15);
                Balra(90);
                Tollat(le);

                //helyezkedés az ívekre
                Tollat(fel);
                Jobbra(90);
                Előre(meret / 7.5);
                Hátra(meret * 3.5 / 10);
                Balra(90);
                Előre(meret * 3.5 / 10);
                Jobbra(90);
                Előre(meret * 8.68 / 10);
                Jobbra(60);
                Tollat(le);

                //ívek
                Ív(60, meret);
                Tollat(fel);
                Balra(30);
                Hátra(meret);
                Tollat(le);

                #region sarkok szinezese
                Tollat(fel);
                Balra(60);
                Előre(meret / 10);
                Tölt(szin2);
                Hátra(meret / 10);
                Jobbra(60);
                Előre(meret);
                Balra(120);
                Előre(meret / 10);
                Tölt(szin2);
                Hátra(meret / 10);
                Balra(60);
                Előre(meret);
                Jobbra(180);
                Tollat(le);
                #endregion

                Ív(90, meret * 8.68 / 10);

                #region a tobbi szinezese
                Tollat(fel);
                Hátra(meret / 1.6);
                Tölt(szin1);
                Jobbra(90);
                Előre(meret / 1.5);
                Tölt(szin2);
                Hátra(meret / 1.5);
                Balra(90);
                Előre(meret / 1.6);
                Tollat(le);
                #endregion

                //helyezkedés a következőre
                Tollat(fel);
                Jobbra(90);
                Előre(meret * 8.68 / 10);
                Jobbra(90);
                Tollat(le);
            }
        }
        void Szele_vert_bal(double meret, int db, Color szin1, Color szin2, Color szin3)
        {
            for (int j = 0; j < db; j++)
            {
                #region korvonal
                if (db != j + 1)
                {
                    Tollszín(szin1);
                    Előre(meret);
                    Tollszín(Color.Black);
                    Balra(90);
                }
                else
                {
                    Előre(meret);
                    Balra(90);
                }
                if (db == 1)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Előre(meret);
                        Balra(90);
                    }
                    Előre(meret * 8.68 / 10);
                    Tollszín(szin1);
                    Előre(meret * 1.32 / 10);
                    Tollszín(Color.Black);
                    Balra(90);
                }
                if (db == j + 1)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Előre(meret);
                        Balra(90);
                    }
                    Előre(meret * 8.68 / 10);
                    Tollat(fel);
                    Előre(meret * 1.32 / 10);
                    Tollat(le);
                    Balra(90);
                }
                else
                {
                    Tollat(fel);
                    Előre(meret * 1.32 / 10);
                    Tollat(le);
                    Előre(meret * 8.68 / 10);
                    Balra(90);
                    Előre(meret);
                    Balra(90);
                    Előre(meret * 8.68 / 10);
                    if (j == 0)
                    {
                        Tollszín(szin1);
                        Előre(meret * 1.32 / 10);
                        Tollszín(Color.Black);
                    }
                    else
                    {
                        Tollat(fel);
                        Előre(meret * 1.32 / 10);
                        Tollat(le);
                    }
                    Balra(90);
                }
                #endregion

                //helyezkedés a körre
                Tollat(fel);
                Balra(90);
                Előre(meret * 6.5 / 10);
                Jobbra(90);
                Előre(meret * 3.5 / 10);
                Hátra(meret / 7.5);
                Balra(90);
                Tollat(le);

                //kör
                Ív(360, meret / 7);

                Tollat(fel);
                Jobbra(90);
                Előre(meret / 15);
                Tölt(szin3);
                Hátra(meret / 15);
                Balra(90);
                Tollat(le);

                //helyezkedés az ívekre
                Tollat(fel);
                Jobbra(90);
                Előre(meret / 7.5);
                Hátra(meret * 3.5 / 10);
                Balra(90);
                Előre(meret * 3.5 / 10);
                Jobbra(90);
                Előre(meret * 8.68 / 10);
                Jobbra(60);
                Tollat(le);

                //ívek
                if (db == j + 1)
                {
                    Ív(60, meret);
                }
                else
                {
                    Ív(52, meret);
                    Balra(112);
                    Előre(meret * 1.32 / 10 * 16 / 30);
                    Hátra(meret * 1.32 / 10 * 16 / 30 / 2);

                    //Itt külön színez
                    Tollat(fel);
                    Balra(90);
                    Előre(meret * 0.32 / 10);
                    Tölt(szin2);
                    Hátra(meret * 0.32 / 10);
                    Jobbra(90);
                    Tollat(le);
                    //----------------

                    Hátra(meret * 1.32 / 10 * 16 / 30 / 2);
                    Jobbra(112);
                    Tollat(fel);
                    Ív(8, meret);
                }
                Balra(30);
                Tollat(fel);
                Hátra(meret);
                Tollat(le);

                #region sar(k)ok szinezese
                Tollat(fel);
                Balra(60);
                Előre(meret / 10);
                Tölt(szin2);
                Hátra(meret / 10);
                Jobbra(60);
                if (db == j + 1)
                {
                    Előre(meret);
                    Balra(120);
                    Előre(meret / 10);
                    Tölt(szin2);
                    Hátra(meret / 10);
                    Balra(60);
                    Előre(meret);
                    Jobbra(180);
                }
                Tollat(le);
                #endregion

                Ív(90, meret * 8.68 / 10);

                #region a tobbi szinezese
                Tollat(fel);
                Hátra(meret / 1.6);
                if (db == j + 1)
                {
                    Tölt(szin1);
                }
                Jobbra(90);
                Előre(meret / 1.5);
                Tölt(szin2);
                Hátra(meret / 1.5);
                Balra(90);
                Előre(meret / 1.6);
                Tollat(le);
                #endregion

                //helyezkedés a következőre
                Tollat(fel);
                Jobbra(90);
                Előre(meret * 8.68 / 10);
                for (int i = 0; i < 2; i++)
                {
                    Jobbra(90);
                    Előre(meret);
                }
                Balra(90);
                Tollat(le);
            }
        }
        void Szele_hor_jobb(double meret, int db, Color szin1, Color szin2, Color szin3)
        {
            for (int j = 0; j < db; j++)
            {
                #region korvonal
                Tollszín(szin1);
                Előre(meret * 8.68 / 10);
                Tollszín(Color.Black);
                Előre(meret * 1.32 / 10);
                Jobbra(90);
                for (int i = 0; i < 2; i++)
                {
                    Előre(meret);
                    Jobbra(90);
                }
                Előre(meret * 8.68 / 10);
                Tollszín(szin1);
                Előre(meret * 1.32 / 10);
                Tollszín(Color.Black);
                Jobbra(90);
                #endregion

                //helyezkedés a körre
                Tollat(fel);
                Jobbra(90);
                Előre(meret * 6.5 / 10);
                Balra(90);
                Előre(meret * 3.5 / 10);
                Hátra(meret / 7.5);
                Balra(90);
                Tollat(le);

                //kör
                Ív(360, meret / 7);

                Tollat(fel);
                Jobbra(90);
                Előre(meret / 15);
                Tölt(szin3);
                Hátra(meret / 15);
                Balra(90);
                Tollat(le);

                //helyezkedés az ívekre
                Tollat(fel);
                Jobbra(90);
                Előre(meret / 7.5);
                Hátra(meret * 3.5 / 10);
                Balra(90);
                Előre(meret * 6.5 / 10);
                Jobbra(90);
                Előre(meret * 8.68 / 10);
                Jobbra(60);
                Tollat(le);

                //ívek
                Ív(60, meret);
                Tollat(fel);
                Balra(30);
                Hátra(meret);
                Tollat(le);

                #region sarkok szinezese
                Tollat(fel);
                Balra(60);
                Előre(meret / 10);
                Tölt(szin2);
                Hátra(meret / 10);
                Jobbra(60);
                Előre(meret);
                Balra(120);
                Előre(meret / 10);
                Tölt(szin2);
                Hátra(meret / 10);
                Jobbra(210);
                Előre(meret * 8.68 / 10);
                Jobbra(90);
                Előre(meret * 8.68 / 10);
                Jobbra(90);
                Tollat(le);
                #endregion

                Ív(90, meret * 8.68 / 10);

                #region a tobbi szinezese
                Tollat(fel);
                Hátra(meret / 1.6);
                Tölt(szin1);
                Jobbra(90);
                Előre(meret / 1.5);
                Tölt(szin2);
                Hátra(meret / 1.5);
                Balra(90);
                Előre(meret / 1.6);
                Tollat(le);
                #endregion

                //helyezkedés a következőre
                Tollat(fel);
                Jobbra(90);
                Előre(meret * 8.68 / 10);
                Jobbra(180);
                Tollat(le);
            }
        }
        void Szele_vert_jobb(double meret, int db, Color szin1, Color szin2, Color szin3)
        {
            for (int j = 0; j < db; j++)
            {
                #region korvonal
                if (db != j + 1)
                {
                    Tollszín(szin1);
                    Előre(meret);
                    Tollszín(Color.Black);
                    Jobbra(90);
                }
                else
                {
                    Előre(meret);
                    Jobbra(90);
                }
                if (db == 1)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Előre(meret);
                        Jobbra(90);
                    }
                    Előre(meret * 8.68 / 10);
                    Tollszín(szin1);
                    Előre(meret * 1.32 / 10);
                    Tollszín(Color.Black);
                    Jobbra(90);
                }
                if (db == j + 1)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Előre(meret);
                        Jobbra(90);
                    }
                    Előre(meret * 8.68 / 10);
                    Tollat(fel);
                    Előre(meret * 1.32 / 10);
                    Tollat(le);
                    Jobbra(90);
                }
                else
                {
                    Tollat(fel);
                    Előre(meret * 1.32 / 10);
                    Tollat(le);
                    Előre(meret * 8.68 / 10);
                    Jobbra(90);
                    Előre(meret);
                    Jobbra(90);
                    Előre(meret * 8.68 / 10);
                    if (j == 0)
                    {
                        Tollszín(szin1);
                        Előre(meret * 1.32 / 10);
                        Tollszín(Color.Black);
                    }
                    else
                    {
                        Tollat(fel);
                        Előre(meret * 1.32 / 10);
                        Tollat(le);
                    }
                    Jobbra(90);
                }
                #endregion

                //helyezkedés a körre
                Tollat(fel);
                Jobbra(90);
                Előre(meret * 6.5 / 10);
                Balra(90);
                Előre(meret * 3.5 / 10);
                Hátra(meret / 7.5);
                Balra(90);
                Tollat(le);

                //kör
                Ív(360, meret / 7);

                Tollat(fel);
                Jobbra(90);
                Előre(meret / 15);
                Tölt(szin3);
                Hátra(meret / 15);
                Balra(90);
                Tollat(le);

                //helyezkedés az ívekre
                Tollat(fel);
                Jobbra(90);
                Előre(meret / 7.5);
                Hátra(meret * 3.5 / 10);
                Balra(90);
                Előre(meret * 6.5 / 10);
                Jobbra(90);
                Előre(meret * 8.68 / 10);
                Jobbra(60);
                Tollat(le);

                //ívek
                if (db == j + 1)
                {
                    Ív(60, meret);
                }
                else
                {
                    Tollat(fel);
                    Ív(8, meret);
                    Tollat(le);

                    Balra(68);
                    Előre(meret * 1.32 / 10 * 16 / 30);
                    Hátra(meret * 1.32 / 10 * 16 / 30);
                    Jobbra(68);
                    Ív(52, meret);

                    //Itt külön színez
                    Tollat(fel);
                    Balra(30);
                    Hátra(meret);
                    Balra(30);
                    Ív(8, meret);
                    Balra(68);
                    Előre(meret * 1.32 / 10 * 16 / 30 / 2);

                    Jobbra(90);
                    Előre(meret * 0.32 / 10);
                    Tölt(szin2);
                    Hátra(meret * 0.32 / 10);
                    Balra(90);
                    Hátra(meret * 1.32 / 10 * 16 / 30 / 2);
                    //----------------

                    Jobbra(68);
                    Ív(52, meret);
                    Tollat(le);
                }
                Balra(30);

                #region sar(k)ok szinezese
                Tollat(fel);
                Balra(120);
                Előre(meret / 10);
                Tölt(szin2);
                Hátra(meret / 10);
                Balra(60);
                Előre(meret);
                if (db == j + 1)
                {
                    Jobbra(120);
                    Előre(meret / 10);
                    Tölt(szin2);
                    Hátra(meret / 10);
                    Balra(120);
                }
                Balra(90);
                Előre(meret * 8.68 / 10);
                Balra(90);
                Előre(meret * 1.32 / 10);
                Balra(90);
                Tollat(le);
                #endregion

                Ív(90, meret * 8.68 / 10);

                #region a tobbi szinezese
                Tollat(fel);
                Hátra(meret / 1.6);
                if (db == j + 1)
                {
                    Tölt(szin1);
                }
                Jobbra(90);
                Előre(meret / 1.5);
                Tölt(szin2);
                Hátra(meret / 1.5);
                Balra(90);
                Előre(meret / 1.6);
                Tollat(le);
                #endregion

                //helyezkedés a következőre
                Tollat(fel);
                Balra(90);
                Előre(meret * 1.32 / 10);
                Balra(90);
                Előre(meret);
                Jobbra(90);
                Tollat(le);
            }
        }

        void Szele_korbe(double meret, int db1, int db2, Color szin1, Color szin2, Color szin3)
        {
            // |_ "alak"
            Szele_hor_bal(meret, (db1 - 2) / 2, szin1, szin2, szin3);
            Szele_vert_bal(meret, db2, szin1, szin2, szin3);

            //helyezkedés 1
            Tollat(fel);
            Hátra(meret);
            Jobbra(90);
            Előre(meret * (db1 - 2) / 2);
            Balra(90);
            Tollat(le);

            //  _
            // |_ "alak"
            Szele_hor_bal(meret, (db1 - 2) / 2, szin1, szin2, szin3);

            //helyezkedés 2
            Tollat(fel);
            Jobbra(90);
            Előre(meret * (db1 - 2) / 2);
            Balra(90);
            Tollat(le);

            //  __
            // |_  "alak"
            Szele_hor_jobb(meret, (db1 - 2) / 2, szin1, szin2, szin3);

            //helyezkedés 3
            Tollat(fel);
            Hátra(meret * (db2 - 1));
            Tollat(le);

            //  __
            // |_ | "alak"
            Szele_vert_jobb(meret, db2, szin1, szin2, szin3);

            //helyezkedés 4
            Tollat(fel);
            Hátra(meret * db2);
            Balra(90);
            Előre(meret * (db1 - 2) / 2);
            Jobbra(90);
            Tollat(le);

            //  __
            // |__| "alak"
            Szele_hor_jobb(meret, (db1 - 2) / 2, szin1, szin2, szin3);
        }
        #endregion

        #region Mak
        void Szivecske_fel(double meret, Color szin)
        {
            //teteje
            Tollszín(szin);
            Bezier(meret * 6 / 10, 150, meret * 6 / 10, 75, meret);
            Balra(120);
            Bezier(meret * 6 / 10, 180, meret * 6 / 10, 75, meret);
            Balra(20);

            //alja
            Ív(40, meret * 2.83);
            Jobbra(80);
            Ív(40, meret * 2.83);

            //színezés
            Tollat(fel);
            Jobbra(100);
            Előre(meret);
            Tölt(szin);
            Hátra(meret);
            Balra(90);
            Tollat(le);
            Tollszín(Color.Black);
        }
        void Szivecske_le(double meret, Color szin)
        {
            //teteje
            Jobbra(180);
            Tollszín(szin);
            Bezier(meret * 6 / 10, -30, meret * 6 / 10, 75, meret);
            Jobbra(60);
            Bezier(meret * 6 / 10, 0, meret * 6 / 10, 75, meret);
            Balra(180);
            Balra(20);

            //alja
            Ív(40, meret * 2.83);
            Jobbra(80);
            Ív(40, meret * 2.83);

            //színezés
            Tollat(fel);
            Jobbra(100);
            Előre(meret);
            Tölt(szin);
            Hátra(meret);
            Balra(90);
            Tollat(le);
            Tollszín(Color.Black);
        }
        void Csontalak(double meret, Color szin)
        {
            //csont
            Tollszín(szin);
            Jobbra(10);
            for (int k = 0; k < 2; k++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int i = 0; i < 40; i++)
                    {
                        Előre(meret / 160);
                        Jobbra(1);
                    }
                    Balra(100);
                }
                Jobbra(220);
                for (int i = 0; i < 40; i++)
                {
                    Előre(meret / 40);
                    Balra(1);
                }
                Jobbra(120);
            }

            //színezés
            Tollat(fel);
            Jobbra(30);
            Előre(meret / 4);
            Tölt(szin);
            Hátra(meret / 4);
            Balra(30);
            Tollat(le);
            Tollszín(Color.Black);
        }
        void Lohere(double meret, Color szin)
        {
            //lóhere            
            int fok = 135;
            Tollszín(szin);
            for (int i = 1; i < 9; i++)
            {
                Bezier(meret * 5.5 / 10, fok, meret * 5.5 / 10, 67.5, meret);
                Balra((i - 1) * 45);
                Balra(90);
                fok += 45;
            }
            Tollszín(Color.Black);

            //színezés
            Tollat(fel);
            Jobbra(90);
            Előre(meret);
            Tölt(szin);
            Hátra(meret);
            Balra(90);
            Tollat(le);
        }
        void Mak_kozepe_minta(double meret, Color szin1, Color szin2, Color szin3)
        {
            //helyezkedés
            Tollat(fel);
            Előre(meret * 258.5 / 100);
            Jobbra(90);
            Előre(meret * 1.5 / 100);
            Balra(90);
            Tollat(le);

            //szivecske le
            Szivecske_le(meret * 30 / 100, szin1);

            //csontalak
            Tollat(fel);
            Előre(meret * 3 / 10);
            Balra(90);
            Előre(meret * 1 / 10);
            Jobbra(90);
            Tollat(le);
            Csontalak(meret * 78.5 / 100, szin2);

            //lóhere
            Tollat(fel);
            Balra(10);
            Előre(meret * 5.2 / 10);
            Jobbra(90);
            Előre(meret * 5.7 / 10);
            Jobbra(90);
            Tollat(le);
            Lohere(meret * 20 / 100, szin1);

            //csontalak2
            Tollat(fel);
            Jobbra(180);
            Előre(meret * 5.7 / 10);
            Jobbra(90);
            Hátra(meret * 5.7 / 10);
            Balra(90);
            Tollat(le);
            Csontalak(meret * 78.5 / 100, szin2);

            //szivecske fel
            Tollat(fel);
            Balra(10);
            Előre(meret * 6.15 / 10);
            Jobbra(90);
            Előre(meret * 6.705 / 10);
            Jobbra(90);
            Tollat(le);
            Szivecske_fel(meret * 30 / 100, szin1);

            //helyezkedés2
            Tollat(fel);
            Hátra(meret * 64 / 100);
            Jobbra(90);
            Előre(meret * 29 / 100);
            Balra(90);
            Tollat(le);

            //vonal
            int fok = 80;
            Balra(80);
            Tollszín(szin3);
            for (int i = 0; i < 2; i++)
            {
                Bezier(meret * 127 / 100, fok, meret * 127 / 100, 80, meret * 327 / 100);
                Jobbra(100);
                fok += 180;
            }
            Tollszín(Color.Black);
        }

        void Mak_kozepe(double meret, Color szin1, Color szin2, Color szin3, Color szin4)
        {
            Mak_kozepe_minta(meret, szin1, szin2, szin3);

            #region vonalak
            //helyezkedés
            Tollat(fel);
            Balra(190);
            Előre(meret * 50 / 100);
            Tollat(le);

            //vonal2
            int fok = 60;
            Tollszín(szin3);
            for (int i = 0; i < 2; i++)
            {
                Jobbra(30);
                Bezier(meret * 135 / 100, fok, meret * 135 / 100, 60, meret * 327 / 100);
                Tollat(fel);
                Jobbra(90);
                Előre(meret * 100 / 100);
                Tollat(le);
                fok += 180;
            }
            Tollszín(Color.Black);

            //helyezkedés2
            Tollat(fel);
            Balra(180);
            Előre(meret * 200 / 100);
            Tollat(le);
            Előre(meret * 40 / 100);

            //volnal3
            int fok2 = 80;
            Tollszín(szin3);
            for (int i = 1; i < 3; i++)
            {
                Jobbra(10);
                Bezier(meret * 143 / 100, fok2, meret * 143 / 100, 80, meret * 327 / 100);
                Tollat(fel);
                Jobbra(90);
                Tollat(le);
                Jobbra((i - 1) * 180);
                Előre(meret * 40 / 100);
                Tollat(fel);
                Előre(meret * 100 / 100);
                Tollat(le);
                Előre(meret * 40 / 100);
                fok2 += 180;
            }
            Tollszín(Color.Black);
            #endregion

            #region szirmok
            void Szinez()
            {
                Tollat(fel);
                Balra(45);
                Előre(meret * 30 / 100);
                Tölt(szin2);
                Hátra(meret * 30 / 100);
                Jobbra(45);
                Tollat(le);
            }

            #region szirmok
            Tollszín(szin2);
            Balra(62);
            Bezier(meret * 40 / 100, 26, meret * 40 / 100, 90, meret * 69.5 / 100);
            Balra(26);

            Szinez();

            Jobbra(31);
            Bezier(meret * 45 / 100, 58, meret * 45 / 100, 90, meret * 69.5 / 100);
            Balra(60);

            Szinez();

            Jobbra(25);
            Bezier(meret * 50 / 100, 90, meret * 50 / 100, 90, meret * 69.5 / 100);
            Balra(82);

            Szinez();

            Jobbra(8);
            Bezier(meret * 50 / 100, 98, meret * 50 / 100, 90, meret * 69.5 / 100);
            Balra(99);

            Szinez();

            Jobbra(22);
            Bezier(meret * 45 / 100, 120, meret * 45 / 100, 90, meret * 69.5 / 100);
            Balra(120);

            Szinez();
            Jobbra(28);
            Bezier(meret * 40 / 100, 151, meret * 40 / 100, 90, meret * 69.5 / 100);
            Balra(149);

            Szinez();
            Tollszín(Color.Black);
            #endregion

            //helyezkedés3
            Tollat(fel);
            Jobbra(121);
            Előre(meret * 180 / 100);
            Előre(meret * 7 / 100);
            Tollat(le);

            #region szirmok2
            Tollszín(szin2);
            Balra(61);
            Bezier(meret * 40 / 100, 206, meret * 40 / 100, 90, meret * 69.5 / 100);
            Balra(207);

            Szinez();

            Jobbra(35);
            Bezier(meret * 45 / 100, 238, meret * 45 / 100, 90, meret * 69.5 / 100);
            Balra(241);

            Szinez();

            Jobbra(20);
            Bezier(meret * 50 / 100, 270, meret * 50 / 100, 90, meret * 69.5 / 100);
            Balra(259);

            Szinez();

            Jobbra(7);
            Bezier(meret * 50 / 100, 278, meret * 50 / 100, 90, meret * 69.5 / 100);
            Balra(294);

            Szinez();

            Jobbra(36);
            Bezier(meret * 45 / 100, 300, meret * 45 / 100, 90, meret * 69.5 / 100);
            Balra(298);

            Szinez();

            Jobbra(31);
            Bezier(meret * 40 / 100, 331, meret * 40 / 100, 90, meret * 69.5 / 100);
            Balra(330);

            Szinez();
            Tollszín(Color.Black);
            #endregion
            #endregion

            #region zold korok
            void Szinez2()
            {
                Tollat(fel);
                Jobbra(90);
                Előre(meret * 9 / 100);
                Tölt(szin1);
                Hátra(meret * 9 / 100);
                Balra(90);
                Tollat(le);
            }

            void Kisebb_kor()
            {
                Tollszín(szin1);
                Ív(360, meret * 18 / 100);
                Tollszín(Color.Black);

                Szinez2();
            }

            void Nagyobb_kor()
            {
                Tollszín(szin1);
                Ív(360, meret * 21.5 / 100);
                Tollszín(Color.Black);

                Szinez2();
            }

            #region megy0
            Tollat(fel);
            Balra(152);
            Előre(meret * 87 / 100);
            Balra(90);
            Előre(meret * 9.5 / 100);
            Jobbra(90);
            Tollat(le);
            #endregion
            Kisebb_kor();
            #region megy
            Tollat(fel);
            Előre(meret * 78 / 100);
            Jobbra(90);
            Előre(meret * 10 / 100);
            Balra(90);
            Tollat(le);
            #endregion
            Nagyobb_kor();
            #region megy
            Tollat(fel);
            Előre(meret * 78 / 100);
            Balra(90);
            Előre(meret * 11 / 100);
            Jobbra(90);
            Tollat(le);
            #endregion
            Kisebb_kor();
            #region megy1
            Tollat(fel);
            Balra(90);
            Előre(meret * 167 / 100);
            Balra(90);
            Tollat(le);
            #endregion
            Kisebb_kor();
            #region megy
            Tollat(fel);
            Előre(meret * 78 / 100);
            Jobbra(90);
            Előre(meret * 10 / 100);
            Balra(90);
            Tollat(le);
            #endregion
            Nagyobb_kor();
            #region megy
            Tollat(fel);
            Előre(meret * 78 / 100);
            Balra(90);
            Előre(meret * 10 / 100);
            Jobbra(90);
            Tollat(le);
            #endregion
            Kisebb_kor();
            #endregion

            #region korok kozt szinezes
            void Szinez3()
            {
                Előre(meret * 39 / 100);
                Balra(90);
                Előre(meret * 30 / 100);
                Tölt(szin4);
                Hátra(meret * 30 / 100);
                Jobbra(90);
                Előre(meret * 39 / 100);
                Balra(90);
                Előre(meret * 10 / 100);
                Jobbra(90);
            }

            void Szinez4()
            {
                Előre(meret * 39 / 100);
                Balra(90);
                Előre(meret * 30 / 100);
                Tölt(szin4);
                Hátra(meret * 30 / 100);
                Jobbra(90);
                Előre(meret * 39 / 100);
                Jobbra(90);
                Előre(meret * 10 / 100);
                Balra(90);
            }

            Tollat(fel);
            Jobbra(180);
            Szinez3();
            Szinez4();

            //átmegy
            Jobbra(90);
            Előre(meret * 167 / 100);
            Jobbra(90);

            Szinez3();
            Szinez4();
            Tollat(le);
            #endregion
        }

        void Mak_alja(double meret, Color szin)
        {
            //helyezkedés
            Tollat(fel);
            Előre(meret * 87 / 100);
            Balra(90);
            Előre(meret * 7 / 100);
            Jobbra(90);

            Előre(meret * 20 / 100);
            Jobbra(90);
            Előre(meret * 5 / 100);
            Tollat(le);

            #region mak alja
            Tollszín(szin);
            Előre(meret * 168 / 100);
            Balra(60);
            Ív(105, meret * 75 / 100);

            Tollat(fel);
            Balra(45);
            Hátra(meret * 404 / 100);
            Tollat(le);

            Balra(45);
            Ív(105, meret * 75 / 100);

            Tollat(fel);
            Balra(60);
            Előre(meret * 168 / 100);
            Balra(60);
            Ív(105, meret * 75 / 100);
            Balra(45);
            Hátra(meret * 404 / 100);
            Tollat(le);

            Balra(90);
            Bezier(meret * 40 / 60, 330, meret * 30 / 60, 75, meret * 180 / 100);
            Balra(240);
            Balra(55);
            Ív(20, meret * 120 / 100);
            Jobbra(70);
            Ív(20, meret * 120 / 100);
            Balra(55);
            Balra(60);
            Bezier(meret * 30 / 60, 0, meret * 40 / 60, 75, meret * 180 / 100);
            Tollszín(Color.Black);
            //színezés
            if (szin != Color.White)
            {
                Tollat(fel);
                Balra(90);
                Előre(meret * 90 / 100);
                Tölt(szin);
                Hátra(meret * 90 / 100);
                Jobbra(90);
                Tollat(le);
            }
            #endregion

            //színezés
            Tollat(fel);
            Balra(120);
            Előre(meret * 2);
            Tölt(szin);
            Hátra(meret * 2);
            Balra(90);
            Tollat(le);
        }

        void Mak_teteje(double meret, Color szin1, Color szin2)
        {
            //helyezkedes
            Tollat(fel);
            Előre(meret * 385 / 100);
            Jobbra(90);
            Előre(meret * 120 / 100);
            Tollat(le);

            //mák teteje
            #region mak tetejenek korvonala
            Tollszín(szin2);

            Előre(meret * 168 / 100);
            Balra(90);
            Bezier(meret * 35 / 60, 135, meret * 28 / 60, 50, meret * 120 / 100);
            Balra(135);
            Bezier(meret * 34 / 60, 200, meret * 34 / 60, -80, meret * 135 / 100);
            Jobbra(70);

            Tollat(fel);
            Előre(meret * 86 / 100);
            Tollat(le);

            Jobbra(90);
            Előre(meret * 30 / 100);
            Jobbra(90);
            Ív(60, meret * 50 / 100);
            Balra(120);
            Ív(60, meret * 50 / 100);
            Jobbra(90);
            Előre(meret * 30 / 100);

            Tollat(fel);
            Jobbra(90);
            Előre(meret * 87 / 100);
            Tollat(le);

            Jobbra(70);
            Bezier(meret * 34 / 60, 180, meret * 34 / 60, -80, meret * 135 / 100);
            Balra(115);
            Bezier(meret * 28 / 60, 180, meret * 35 / 60, 85, meret * 120 / 100);
            Jobbra(135);

            Tollszín(Color.Black);
            #endregion

            #region mak tetejenek belseje
            Tollszín(szin1);
            //helyezkedés 1
            Tollat(fel);
            Jobbra(45);
            Előre(meret * 30 / 100);
            Balra(45);
            Tollat(le);

            //bal oldali valami
            Bezier(meret * 10 / 60, -90, meret * 30 / 60, -35, meret * 100 / 100);
            Jobbra(150);
            Bezier(meret * 45 / 60, 180, meret * 10 / 60, 78, meret * 105 / 100);
            Balra(60);
            Ív(170, meret * 7 / 100);
            //színezés
            Tollat(fel);
            Jobbra(30);
            Előre(meret * 20 / 100);
            Tölt(szin1);
            Hátra(meret * 20 / 100);
            Balra(30);
            Tollat(le);

            //helyezkedes 2
            Tollat(fel);
            Jobbra(80);
            Előre(meret * 42.5 / 100);
            Tollat(le);

            //középső valami teteje
            Balra(70);
            Bezier(meret * 2 / 60, -45, meret * 16 / 60, -5, meret * 74 / 100);
            Jobbra(160);
            Ív(40, meret * 65 / 100);
            Balra(130);
            Ív(40, meret * 65 / 100);
            Jobbra(160);
            Bezier(meret * 16 / 60, 180, meret * 2 / 60, -39, meret * 74 / 100);
            //középső valami alja
            Jobbra(140);
            Bezier(meret * 8 / 60, 315, meret * 8 / 60, 90, meret * 24 / 100);
            Jobbra(85);
            Bezier(meret * 8 / 60, 0, meret * 8 / 60, 40, meret * 24 / 100);
            //színezés
            Tollat(fel);
            Jobbra(180);
            Előre(meret * 40 / 100);
            Tölt(szin1);
            Hátra(meret * 40 / 100);
            Balra(180);
            Tollat(le);

            //helyezkedés 3
            Tollat(fel);
            Jobbra(225);
            Előre(meret * 48 / 100);
            Jobbra(24);
            Előre(meret * 29 / 100);
            Balra(114);
            Tollat(le);

            //jobb oldali valami
            Bezier(meret * 10 / 60, 120, meret * 45 / 60, 42, meret * 105 / 100);
            Jobbra(150);
            Bezier(meret * 30 / 60, 180, meret * 10 / 60, -55, meret * 100 / 100);
            Jobbra(120);
            Ív(170, meret * 7 / 100);
            //színezés
            Tollat(fel);
            Előre(meret * 40 / 100);
            Tölt(szin1);
            Hátra(meret * 40 / 100);
            Balra(20);
            Tollat(le);

            //szinezes(kívül)
            if (szin2 != Color.White)
            {
                Tollat(fel);
                Balra(90);
                Előre(meret * 20 / 100);
                Tölt(szin2);
                Hátra(meret * 20 / 100);
                Jobbra(90);
                Tollat(le);
            }

            Tollszín(Color.Black);
            #endregion
        }

        void Mak(double meret, Color szin1, Color szin2, Color szin3, Color szin4)
        {
            //helyezkedés
            Tollat(fel);
            Előre(60);
            Tollat(le);

            //mák
            Mak_kozepe(meret, szin1, szin2, szin3, szin4);
            Mak_alja(meret, szin3);
            Mak_teteje(meret, szin1, szin3);
        }
        #endregion
        #endregion
        #endregion

        void FELADAT()
		{
            

		}
	}
}
