using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		/* Függvények */


		/* Függvények vége */
		void FELADAT()
		{
			/* Ezt indítja a START gomb! */
			// Teleport(közép.X, közép.Y+150, észak);
			//Alap(100, Color.Black);
			//Harfa(100, Color.DarkGreen);
			using (new Frissítés(false))
            {
			Virágbelső(100, Color.Black);
				using (new Rajzol(false))
					Előre(10);
			Jobbra(90);
				Virágkülső(65, Color.Black);

            }
			//alap_viragbelso(100, Color.DarkGreen, Color.Black);
		}
	}
}
