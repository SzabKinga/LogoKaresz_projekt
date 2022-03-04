using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		void Külső_vonal_bal(double meret)
        {


			Balra(90);
            Bezier(50, 0, 50, 80, 100, false, false);
			Jobbra(50);
			for (int i = 0; i < 10; i++)
			{
				Előre(1);
				Balra(1 + i);

			}

			Tollat(fel);
			Jobbra(5);
			Hátra(25);
			Jobbra(90);
			Hátra(105);

			Tollat(le);
			










		}

		void Külső_vonal_jobb(double meret)
		{


			Bezier(-100, 175, -50, 120, 150, false, false);



		}
		void FELADAT()
		{
			Külső_vonal_bal(100);



		}
	}
}
