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
			//Szele_korbe(40, 8, 8, Color.DarkOrange, Color.Black, Color.White);

			Tollat(fel);
			Előre(260);
			Tollat(le);
			Szivecske(10, Color.Green);
		}
	}
}
