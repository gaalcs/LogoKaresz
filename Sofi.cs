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
        }
        /// <summary>
        /// a vaza feher szele, merettel szorzod az alap (300-as) meretet
        /// </summary>
        /// <param name="meret"> ennyivel osztod az alap (300-as) meretet</param>
        void vaza_szele_balra(double meret, Color szin)
        {
            Tollszín(szin);
            Bezier(0, 45*meret, 210*meret, 0, 300*meret);
            Balra(90+45*meret);
            Előre(300*meret/6);
            Balra(90);
            Bezier(0, -45*meret, -210*meret, 0, 300*meret);
            Balra(90-45*meret);
            Előre(300*meret/6);
            Balra(90);
            Odatolt(-75, meret * 10, szin);
            Tollszín(Color.Black);
        }
        void vaza_szele_jobbra(double meret, Color szin)
        {
            Tollszín(szin);
            Bezier(0, -45*meret, 210*meret, 0, 300*meret);
            Jobbra(90+45*meret);
            Előre(300*meret/6);
            Jobbra(90);
            Bezier(0, 45*meret, -210*meret, 0, 300*meret);
            Jobbra(90-45*meret);
            Előre(300*meret/6);
            Jobbra(90);
            Odatolt(75,meret*10,szin);
            Tollszín(Color.Black);
        }
        /// <summary>
        /// a meret azt hatarozza meg hogy az alap meretet mennyivel szorzod meg.
        /// </summary>
        /// <param name="meret"></param>
        /// <param name="szin_kulso"></param>
        /// <param name="szin_belső"></param>
        void tolcser_virag_baloldali(double meret,Color szin_kulso,Color szin_belső)
        {
            #region a virag bal kulso szirma
            Tollszín(szin_kulso);
            Balra((90 + 45)*meret);
            Bezier(90*meret, 90*meret, -70*meret, 75*meret, 200*meret);
            //vissza megy a kezdő pontba & megrajzolja a belso ivet is
            Tollat(fel);
            Balra(15*meret);
            Hátra(200*meret);
            Jobbra(15*meret);
            Előre(20*meret);
            Jobbra(45*meret); 
            Tollat(le);
            Balra((90 + 45)*meret);
            Bezier(70*meret, 70*meret, -85*meret, 73*meret, 180*meret);
            // vissza a kezdőpontba
            Tollat(fel);
            Jobbra(5);           
            Hátra(200 * meret);
            Jobbra(15 * meret);
            Jobbra(45 * meret);
            Tollat(le);
            
            #endregion

        }
    }
}