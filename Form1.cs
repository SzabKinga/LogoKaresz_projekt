using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		void Külső_vonal_bal(double meret, Color szin)
        {
			Tollszín(szin);


			Balra(90);
            Bezier(meret/2, 0, meret/2, 80, meret, false, false);
			Jobbra(50);
			for (int i = 0; i < 10; i++)
			{
				Előre(1);
				Balra(1 + i);

			}

			Tollat(fel);
			Jobbra(5);
			Hátra(meret/3.9);
			Jobbra(90);
			Hátra(meret/ 0.975);

			Tollat(le);
			


		}

		void Külső_vonal_bal_belül(double meret, Color szin)
		{
			Tollszín(szin);


			Balra(90);
			Bezier(meret / 2, 0, meret / 2, 80, meret, false, false);
			Jobbra(50);
			for (int i = 0; i < 3; i++)
			{
				Előre(2);
				Balra(1 + i);

			}

			Tollat(fel);
			Balra(45);
			Hátra(meret / 5);
			Jobbra(90);
			Hátra(meret / 0.965);



			Tollat(le);
			



		}

		void Külső_vonal_jobb(double meret, Color szin)
		{
			Tollszín(szin);

			Jobbra(-90);
			Bezier(-meret/2, 30,meret/5,100, meret, false, false);
		    Jobbra(100);

			for (int i = 0; i < 10; i++)
			{
				Előre(1);
				Jobbra(1 + i);

			}
			Tollat(fel);
			Balra(5);
			Hátra(meret/4);
			Balra(90);
			Hátra(meret/ 0.975);

			Tollat(le);



		}

		void Külső_vonal_jobb_belül(double meret, Color szin)
		{
			Tollszín(szin);

			Jobbra(-90);
			Bezier(-meret / 2, 30, meret / 5, 100, meret, false, false);
			Jobbra(100);

			for (int i = 0; i < 3; i++)
			{
				Előre(2);
				Jobbra(1 + i);

			}
			Tollat(fel);
			Jobbra(40);
			Hátra(meret / 5);
			Balra(90);
			Hátra(meret / 0.965);

			Tollat(le);



		}

		void Üres(int meret, Color szin)
        {
			Külső_vonal_bal(meret, szin);
			Külső_vonal_jobb(meret, szin);

			Tollat(fel);
			Előre(25);
			Tollat(le);
			

			Külső_vonal_bal_belül(meret*0.8, szin);
			Külső_vonal_jobb_belül(meret*0.8, szin);


		}


		void FELADAT()
		{
			/**/
			Külső_vonal_bal(100, Color.Green);
			Külső_vonal_jobb(100, Color.Green);

			Tollat(fel);
			Előre(10);
			Tollat(le);
			

			Külső_vonal_bal_belül(85, Color.Green);
			Külső_vonal_jobb_belül(85, Color.Green);
			/**/
			Tollat(fel);
			Jobbra(5);
			Balra(90);
			Előre(10);
			Jobbra(90);
			Hátra(5);
			Tollat(le);
			Tölt(Color.Green);
			Tollat(fel);
			Előre(5);
			Tollat(le);
			/**/

			



		}
	}
}
