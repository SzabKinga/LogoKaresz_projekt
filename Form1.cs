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
			/** /
			Alap(100, Color.Black);
			Harfa(100, Color.DarkGreen);
			alap_viragbelso(100, Color.DarkGreen, Color.Black);
			/**/
			using (new Frissítés(false))
			{
				//Finishedvirag(30, false);
			Vege(Color.Green, Color.DarkGreen, Color.LightGreen);
				using (new Rajzol(false))
				{
					Előre(60);
					Jobbra(90);
					Előre(15);
					Jobbra(90);
				}
				Virág(45, Color.Black, Color.DarkGreen);
			}

		}
	}
}
