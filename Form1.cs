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
			
			szár_bal_nagy(Color.Black);
			
			kis_háromszög(Color.Black);
			
			kishullám(Color.DarkOliveGreen);

			nagyhullám(Color.Black);
			
			szár_bal_kicsi(Color.DarkOliveGreen);

			szár_jobb_kicsi(Color.DarkOliveGreen);
			
			nagy_háromszög(Color.DarkOliveGreen);

			szirom(Color.Black);

			Középső_szirom(Color.DarkOliveGreen);

			kisvirág(Color.Black);

			nagyvirág(Color.DarkOliveGreen);

			helyedre();
			
		}
	}
}
