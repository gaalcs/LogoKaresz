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
        void Szele_hor(double meret, int db, Color szin1, Color szin2, Color szin3)
        {
            for (int j = 0; j < db; j++)
            {
                #region korvonal
                for (int i = 0; i < 4; i++)
                {
                    Előre(meret);
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
                Előre(meret * 8.7/10);
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

                Ív(90, meret * 8.7/10);

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
                Előre(meret * 8.7/10);
                Jobbra(90);
                Tollat(le);
                #endregion
            }
        }

        void Szele_vert(double meret, int db, Color szin1, Color szin2, Color szin3)
        {
            for (int j = 0; j < db; j++)
            {
                #region korvonal
                if (db == j+1)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Előre(meret);
                        Balra(90);
                    }
                    Előre(meret * 8.7 / 10);
                    Tollat(fel);
                    Előre(meret * 1.3 / 10);
                    Tollat(le);
                    Balra(90);
                }
                else
                {
                    Előre(meret);
                    Balra(90);
                    Tollat(fel);
                    Előre(meret * 1.3/10);
                    Tollat(le);
                    Előre(meret * 8.7/10);
                    Balra(90);
                    Előre(meret);
                    Balra(90);
                    Előre(meret * 8.7 / 10);
                    if (j == 0)
                    {
                        Előre(meret * 1.3 / 10);
                    }
                    else
                    {
                        Tollat(fel);
                        Előre(meret * 1.3 / 10);
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
                    Előre(meret * 1.3/10 * 16/30);
                    Hátra(meret * 1.3/10 * 16/30 / 2);
                    
                    //Itt külön színez
                    Tollat(fel);
                    Balra(90);
                    Előre(meret * 0.3/10);
                    Tölt(szin2);
                    Hátra(meret * 0.3/10);
                    Jobbra(90);
                    Tollat(le);
                    //----------------

                    Hátra(meret * 1.3/10 * 16/30 / 2);
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

        void Szele_korbe(double meret, int db1, int db2, Color szin1, Color szin2, Color szin3)
        {
            Szele_hor(meret, db1-2, szin1, szin2, szin3);
            Szele_vert(meret, db2, szin1, szin2, szin3);
            
            Tollat(fel);
            Hátra(meret);
            Jobbra(90);
            Előre(meret * (db1-2));
            Balra(90);
            Tollat(le);

            Szele_hor(meret, db1-2, szin1, szin2, szin3);

            Tollat(fel);
            Jobbra(90);
            Előre(meret * (db1-2));
            Balra(90);
            Hátra(meret * (db2-1));
            Jobbra(90);
            Előre(meret);
            Balra(90);
            Tollat(le);

            Szele_vert(meret, db2, szin1, szin2, szin3);
        }
        #endregion


    }
}
