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
			Teleport(közép.X-100, közép.Y+50, észak);
			

			kis_háromszög(Color.Black);
			
			kishullám(Color.DarkOliveGreen);

			nagyhullám(Color.Black);

			//
			Tollat(fel);
			Előre(10);
			Tollat(le);

			nagy_háromszög(Color.DarkOliveGreen);


			/*
			Tollat(fel);
			Előre(100);
			Tollat(le);
			*/

		}
	}
}
