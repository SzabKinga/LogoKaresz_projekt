﻿using System;
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
				Virág(150, Color.Black, Color.DarkGreen);
			
			//alap_viragbelso(100, Color.DarkGreen, Color.Black);
		}
	}
}
