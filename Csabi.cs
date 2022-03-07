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

                #region helyezkedes a korre
                Tollat(fel);
                Balra(90);
                Előre(meret * 6.5/10);
                Jobbra(90);
                Előre(meret * 3.5/10);
                Hátra(meret / 7.5);
                Balra(90);
                Tollat(le);
                #endregion

                #region kor
                Ív(360, meret / 7);
            
                Tollat(fel);
                Jobbra(90);
                Előre(meret / 15);
                Tölt(szin3);           
                Hátra(meret / 15);
                Balra(90);
                Tollat(le);
                #endregion

                #region helyetkedes az ivekre
                Tollat(fel);
                Jobbra(90);
                Előre(meret / 7.5);
                Hátra(meret * 3.5/10);
                Balra(90);
                Előre(meret * 3.5/10);
                Jobbra(90);
                Előre(meret * 8.68 / 10);
                Jobbra(60);
                Tollat(le);
                #endregion

                #region ivek
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
                #endregion

                #region helyezkedes a kovetkezore
                Tollat(fel);
                Jobbra(90);
                Előre(meret * 8.68 / 10);
                Jobbra(90);
                Tollat(le);
                #endregion
            }
        }

        void Szele_vert_bal(double meret, int db, Color szin1, Color szin2, Color szin3)
        {
            for (int j = 0; j < db; j++)
            {
                #region korvonal
                if (db != j+1)
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
                if (db == j+1)
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
                    Előre(meret * 1.32/10);
                    Tollat(le);
                    Előre(meret * 8.68/10);
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

                #region helyezkedes a korre
                Tollat(fel);
                Balra(90);
                Előre(meret * 6.5/10);
                Jobbra(90);
                Előre(meret * 3.5/10);
                Hátra(meret / 7.5);
                Balra(90);
                Tollat(le);
                #endregion

                #region kor
                Ív(360, meret / 7);

                Tollat(fel);
                Jobbra(90);
                Előre(meret / 15);
                Tölt(szin3);
                Hátra(meret / 15);
                Balra(90);
                Tollat(le);
                #endregion

                #region helyetkedes az ivekre
                Tollat(fel);
                Jobbra(90);
                Előre(meret / 7.5);
                Hátra(meret * 3.5/10);
                Balra(90);
                Előre(meret * 3.5/10);
                Jobbra(90);
                Előre(meret * 8.68/10);
                Jobbra(60);
                Tollat(le);
                #endregion

                #region ivek
                if (db == j+1)
                {
                    Ív(60, meret);
                }
                else
                {
                    Ív(52, meret);
                    Balra(112);
                    Előre(meret * 1.32/10 * 16/30);
                    Hátra(meret * 1.32/10 * 16/30 / 2);
                    
                    //Itt külön színez
                    Tollat(fel);
                    Balra(90);
                    Előre(meret * 0.32/10);
                    Tölt(szin2);
                    Hátra(meret * 0.32/10);
                    Jobbra(90);
                    Tollat(le);
                    //----------------

                    Hátra(meret * 1.32/10 * 16/30 / 2);
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
                if (db == j+1)
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

                Ív(90, meret * 8.68/10);

                #region a tobbi szinezese
                Tollat(fel);
                Hátra(meret / 1.6);
                if (db == j+1)
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
                #endregion

                #region helyezkedes a kovetkezore
                Tollat(fel);
                Jobbra(90);
                Előre(meret * 8.68/10);
                for (int i = 0; i < 2; i++)
                {
                    Jobbra(90);
                    Előre(meret);
                }
                Balra(90);
                Tollat(le);
                #endregion
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
                Előre(meret * 8.68/10);
                Tollszín(szin1);
                Előre(meret * 1.32/10);
                Tollszín(Color.Black);
                Jobbra(90);
                #endregion

                #region helyezkedes a korre
                Tollat(fel);
                Jobbra(90);
                Előre(meret * 6.5 / 10);
                Balra(90);
                Előre(meret * 3.5 / 10);
                Hátra(meret / 7.5);
                Balra(90);
                Tollat(le);
                #endregion

                #region kor
                Ív(360, meret / 7);

                Tollat(fel);
                Jobbra(90);
                Előre(meret / 15);
                Tölt(szin3);
                Hátra(meret / 15);
                Balra(90);
                Tollat(le);
                #endregion

                #region helyetkedes az ivekre
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
                #endregion

                #region ivek
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
                Előre(meret * 8.68/10);
                Jobbra(90);
                Előre(meret * 8.68/10);
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
                #endregion

                #region helyezkedes a kovetkezore
                Tollat(fel);
                Jobbra(90);
                Előre(meret * 8.68 / 10);
                Jobbra(180);
                Tollat(le);
                #endregion
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
                if (db == j+1)
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

                #region helyezkedes a korre
                Tollat(fel);
                Jobbra(90);
                Előre(meret * 6.5 / 10);
                Balra(90);
                Előre(meret * 3.5 / 10);
                Hátra(meret / 7.5);
                Balra(90);
                Tollat(le);
                #endregion

                #region kor
                Ív(360, meret / 7);

                Tollat(fel);
                Jobbra(90);
                Előre(meret / 15);
                Tölt(szin3);
                Hátra(meret / 15);
                Balra(90);
                Tollat(le);
                #endregion

                #region helyetkedes az ivekre
                Tollat(fel);
                Jobbra(90);
                Előre(meret / 7.5);
                Hátra(meret * 3.5/10);
                Balra(90);
                Előre(meret * 6.5/10);
                Jobbra(90);
                Előre(meret * 8.68 / 10);
                Jobbra(60);
                Tollat(le);
                #endregion

                #region ivek
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
                Előre(meret * 8.68/10);
                Balra(90);
                Előre(meret * 1.32/10);
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
                #endregion

                #region helyezkedes a kovetkezore
                Tollat(fel);
                Balra(90);
                Előre(meret * 1.32 / 10);
                Balra(90);
                Előre(meret);
                Jobbra(90);
                Tollat(le);
                #endregion
            }
        }

//--------------------------------------------------------------------------------------------------------

        void Szele_korbe(double meret, int db1, int db2, Color szin1, Color szin2, Color szin3)
        {
            Szele_hor_bal(meret, (db1-2) / 2, szin1, szin2, szin3);
            Szele_vert_bal(meret, db2, szin1, szin2, szin3);
            
            Tollat(fel);
            Hátra(meret);
            Jobbra(90);
            Előre(meret * (db1-2) / 2);
            Balra(90);
            Tollat(le);

            Szele_hor_bal(meret, (db1-2) / 2, szin1, szin2, szin3);

            Tollat(fel);
            Jobbra(90);
            Előre(meret * (db1 - 2) / 2);
            Balra(90);
            Tollat(le);

            Szele_hor_jobb(meret, (db1 - 2) / 2, szin1, szin2, szin3);

            Tollat(fel);
            Hátra(meret * (db2-1));
            Tollat(le);

            Szele_vert_jobb(meret, db2, szin1, szin2, szin3);

            Tollat(fel);
            Hátra(meret * db2);
            Balra(90);
            Előre(meret * (db1-2) / 2);
            Jobbra(90);
            Tollat(le);

            Szele_hor_jobb(meret, (db1-2) / 2, szin1, szin2, szin3);
        }
        #endregion

        #region Szivecske
        void Szivecske_fel(double meret, Color szin)
        {
            #region teteje
            Tollszín(szin);
            Bezier(meret * 6/10, 150, meret * 6/10, 75, meret);
            Balra(120);
            Bezier(meret * 6/10, 180, meret * 6/10, 75, meret);
            Balra(20);
            #endregion

            #region alja
            Ív(40, meret * 2.83);
            Jobbra(80);
            Ív(40, meret * 2.83);
            #endregion

            #region szinez
            Tollat(fel);
            Jobbra(100);
            Előre(meret);
            Tölt(szin);
            Hátra(meret);
            Balra(90);
            Tollat(le);
            Tollszín(Color.Black);
            #endregion
        }

        void Szivecske_le(double meret, Color szin)
        {
            #region teteje
            Jobbra(180);
            Tollszín(szin);
            Bezier(meret * 6 / 10, -30, meret * 6 / 10, 75, meret);
            Jobbra(60);
            Bezier(meret * 6 / 10, 0, meret * 6 / 10, 75, meret);
            Balra(180);
            Balra(20);
            #endregion

            #region alja
            Ív(40, meret * 2.83);
            Jobbra(80);
            Ív(40, meret * 2.83);
            #endregion

            #region szinez
            Tollat(fel);
            Jobbra(100);
            Előre(meret);
            Tölt(szin);
            Hátra(meret);
            Balra(90);
            Tollat(le);
            Tollszín(Color.Black);
            #endregion
        }
        #endregion

        void Csontalak(double meret, Color szin)
        {
            #region csont
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
            #endregion

            #region szinez
            Tollat(fel);
            Jobbra(30);
            Előre(meret / 4);
            Tölt(szin);
            Hátra(meret / 4);
            Balra(30);
            Tollat(le);
            Tollszín(Color.Black);
            #endregion
        }

        void Lohere(double meret, Color szin)
        {
            #region lohere            
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
            #endregion

            #region szinez
            Tollat(fel);
            Jobbra(90);
            Előre(meret);
            Tölt(szin);
            Hátra(meret);
            Balra(90);
            Tollat(le);
            #endregion
        }

        void Mak_kozepe(double meret, Color szin1, Color szin2, Color szin3)
        {
            #region helyezkedes
            Tollat(fel);
            Előre(meret * 258.5/100);
            Jobbra(90);
            Előre(meret * 1.5/100);
            Balra(90);
            Tollat(le);
            #endregion

            #region szivecske_le
            Szivecske_le(meret * 30/100, szin1);
            #endregion

            #region csontalak
            Tollat(fel);
            Előre(meret * 3/10);
            Balra(90);
            Előre(meret * 1/10);
            Jobbra(90);
            Tollat(le);
            Csontalak(meret * 78.5/100, szin2);
            #endregion

            #region lohere
            Tollat(fel);
            Balra(10);
            Előre(meret * 5.2/10);
            Jobbra(90);
            Előre(meret * 5.7/10);
            Jobbra(90);
            Tollat(le);
            Lohere(meret * 20/100, szin1);
            #endregion

            #region csontalak2
            Tollat(fel);
            Jobbra(180);
            Előre(meret * 5.7/10);
            Jobbra(90);
            Hátra(meret * 5.7/10);
            Balra(90);
            Tollat(le);
            Csontalak(meret * 78.5/100, szin2);
            #endregion

            #region szivecske_fel
            Tollat(fel);
            Balra(10);
            Előre(meret * 6.15/10);
            Jobbra(90);
            Előre(meret * 6.705/10);
            Jobbra(90);            
            Tollat(le);
            Szivecske_fel(meret * 30/100, szin1);
            #endregion

            #region helyezkedes2
            Tollat(fel);
            Hátra(meret * 64/100);
            Jobbra(90);
            Előre(meret * 29/100);
            Balra(90);
            Tollat(le);
            #endregion

            #region vonal
            int fok = 80;
            Balra(80);
            Tollszín(szin3);
            for (int i = 0; i < 2; i++)
            {
                Bezier(meret * 127/100, fok, meret * 127/100, 80, meret * 327/100);
                Jobbra(100);
                fok += 180;
            }
            Tollszín(Color.Black);
            #endregion
        }

        void Mak(double meret, Color szin1, Color szin2, Color szin3, Color szin4)
        {
            Mak_kozepe(meret, szin1, szin2, szin3);

            #region vonalak
            #region helyezkedes
            Tollat(fel);
            Balra(190);
            Előre(meret * 50/100);
            Tollat(le);
            #endregion

            #region vonal2
            int fok = 60;
            Tollszín(szin3);
            for (int i = 0; i < 2; i++)
            {
                Jobbra(30);
                Bezier(meret * 135/100, fok, meret * 135/100, 60, meret * 327/100);
                Tollat(fel);
                Jobbra(90);
                Előre(meret * 100/100);
                Tollat(le);
                fok += 180;
            }
            Tollszín(Color.Black);
            #endregion

            #region helyezkedes2
            Tollat(fel);
            Balra(180);
            Előre(meret * 200/100);
            Tollat(le);
            Előre(meret * 40/100);
            #endregion

            #region volnal3
            int fok2 = 80;
            Tollszín(szin3);
            for (int i = 1; i < 3; i++)
            {
                Jobbra(10);
                Bezier(meret * 143/100, fok2, meret * 143/100, 80, meret * 327/100);
                Tollat(fel);
                Jobbra(90);
                Tollat(le);
                Jobbra((i-1) * 180);
                Előre(meret * 40/100);
                Tollat(fel);
                Előre(meret * 100/100);
                Tollat(le);
                Előre(meret * 40 / 100);
                fok2 += 180;
            }
            Tollszín(Color.Black);
            #endregion
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
            Balra(61);
            Bezier(meret * 40/100, 26, meret * 40/100, 90, meret * 69.5 / 100);
            Balra(26);

            Szinez();

            Jobbra(30);
            Bezier(meret * 45/100, 58, meret * 45/100, 90, meret * 69.5 / 100);
            Balra(60);

            Szinez();

            Jobbra(25);
            Bezier(meret * 50/100, 90, meret * 50/100, 90, meret * 69.5 / 100);
            Balra(82);

            Szinez();

            Jobbra(9);
            Bezier(meret * 50/100, 98, meret * 50/100, 90, meret * 69.5 / 100);
            Balra(99);

            Szinez();

            Jobbra(20);
            Bezier(meret * 45/100, 120, meret * 45/100, 90, meret * 69.5 / 100);
            Balra(120);

            Szinez();

            Jobbra(32);
            Bezier(meret * 40/100, 151, meret * 40/100, 90, meret * 69.5/100);
            Balra(149);

            Szinez();
            Tollszín(Color.Black);
            #endregion

            #region helyezkedes3
            Tollat(fel);
            Jobbra(118);
            Előre(meret * 180/100);
            Előre(meret * 3/100);
            Tollat(le);
            #endregion

            #region szirmok2
            Tollszín(szin2);
            Balra(61);
            Bezier(meret * 40/100, 206, meret * 40/100, 90, meret * 69.5 / 100);
            Balra(207);

            Szinez();

            Jobbra(33);
            Bezier(meret * 45/100, 238, meret * 45/100, 90, meret * 69.5 / 100);
            Balra(241);

            Szinez();

            Jobbra(23);
            Bezier(meret * 50/100, 270, meret * 50/100, 90, meret * 69.5 / 100);
            Balra(259);

            Szinez();

            Jobbra(7);
            Bezier(meret * 50/100, 278, meret * 50/100, 90, meret * 69.5 / 100);
            Balra(294);

            Szinez();

            Jobbra(36);
            Bezier(meret * 45/100, 300, meret * 45/100, 90, meret * 69.5 / 100);
            Balra(298);

            Szinez();

            Jobbra(29);
            Bezier(meret * 40/100, 331, meret * 40/100, 90, meret * 69.5 / 100);
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
            Balra(151);
            Előre(meret * 87/100);
            Balra(90);
            Előre(meret * 7/100);
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
            Előre(meret * 167/100);
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
            #region atmegy
            Jobbra(90);
            Előre(meret * 167 / 100);
            Jobbra(90);
            #endregion
            Szinez3();
            Szinez4();
            Tollat(le);
            #endregion
        }
    }
}
