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

			Mak(57, Color.Green, Color.BurlyWood, Color.White, Color.Black);
			/** /
			Tollat(fel);
			Előre(50);
			Jobbra(90);
			Tollat(le);

			Előre(110);
			Jobbra(90);
			Előre(140);
			Jobbra(90);
			Előre(170);
			Jobbra(90);
			Előre(140);
			Jobbra(90);
			Előre(60);

			Tollat(fel);
			Jobbra(90);
			Előre(20);
			Tölt(Color.Black);
			Hátra(20);
			Balra(90);
			Tollat(le);
			/**/
		}
	}
}

