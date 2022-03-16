using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		void FELADAT()
		{
			/*/* /
			Tollat(fel);
			Hátra(40);
			Tollat(le);
			Szele_korbe(31, 14, 14, Color.DarkOrange, Color.Black, Color.White);
			/**/

			Mak(60, Color.Green, Color.BurlyWood, Color.White, Color.Black);

			/**/
			Tollat(fel);
			Előre(100);
			Tollat(le);
			Jobbra(90);
			Előre(230);
			Jobbra(90);
			Előre(420);
			Jobbra(90);
			Előre(430);
			Jobbra(90);
			Előre(420);
			Jobbra(90);
			Előre(210);

			Tollat(fel);
			Jobbra(90);
			Előre(10);
			Tölt(Color.Black);
			Hátra(10);
			Balra(90);
			Tollat(le);
			/**/
		}
	}
}

