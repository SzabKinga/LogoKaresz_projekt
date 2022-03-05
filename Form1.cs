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

		void Üres(double meret, Color szin)
        {
			/**/
			Külső_vonal_bal(meret, szin);
			Külső_vonal_jobb(meret, szin);

			Tollat(fel);
			Előre(10);
			Tollat(le);


			Külső_vonal_bal_belül(meret*0.85, szin);
			Külső_vonal_jobb_belül(meret*0.85, szin);
			
			Tollat(fel);
			Jobbra(5);
			Balra(90);
			Előre(10);
			Jobbra(90);
			Hátra(5);
			Tollat(le);
			Tölt(szin);
			Tollat(fel);
			Előre(5);
			Tollat(le);
			/**/



		}

		void Közepminta(double meret, Color szin,Color szin2)
        {
			/**/
			Tollszín(szin);

			Jobbra(90);
			Előre(3);
			Balra(90);
            for (int i = 0; i < 13; i++)
            {
				Jobbra(5);
				Előre(2);
            }
			Balra(140);
			for (int i = 0; i < 13; i++)
			{
				Balra(5);
				Előre(1.5);
			}
			
			Tollat(fel);
			Balra(40);
			Előre(14);
			Tollat(le);
			/**/
			Jobbra(90);
			Előre(3);
			Jobbra(90);
           
			/**/
			for (int i = 0; i < 13; i++)
            {
				Balra(5);
				Előre(2);
			}
			Jobbra(140);
			for (int i = 0; i < 13; i++)
			{
				Jobbra(5);
				Előre(1.5);
			}
			Tollat(fel);
			Jobbra(40);
			Előre(14);

			
			Balra(180);
			Tollat(le);
			/**/
			
		
			

			Jobbra(90);
			Tollat(fel);
			Előre(12);
			Balra(90);
			Előre(11);
			Jobbra(90);
			Tollat(le);
			
			Tollszín(szin2);
			
			Ív(360, 2);

			Jobbra(90);
			
			Tollat(fel);
			Előre(2);
			Tollat(le);
			
			Tölt(szin2);
			
			Tollat(fel);
			Hátra(2);
			Tollat(le);

			Balra(90);
			
			Balra(90);
			Tollat(fel);
			Hátra(12);
			Jobbra(90);
			Hátra(11);
			Balra(90);
			

			Balra(90);
			Előre(4);
			Jobbra(90);
			Tollat(le);
			
			Tollszín(szin);


			////
			///

			Jobbra(-90);
			Tollat(fel);
			Előre(11);
			Balra(-90);
			Előre(8.5);
			Jobbra(-90);
			Tollat(le);

			
			Tollszín(szin2);

			Ív(360, 2);
			

			Jobbra(90);
			

			Tollat(fel);
			Előre(2);
			Tollat(le);

			Tölt(szin2);

			Tollat(fel);
			Hátra(2);
			Tollat(le);

			Balra(90);
			

		
			Tollat(fel);
			Hátra(11);
			Jobbra(-90);
			Hátra(8.5);
			Balra(-90);
			/**/
        	Balra(-90);
     		Hátra(15);
			Jobbra(90);
			Előre(3);
			Balra(90);
			Tollat(le);

			Tollszín(szin);
			


			/**/
			Tollat(fel);
			Előre(10);
			Tollat(le);
			Tölt(szin);
			Előre(5.5);
			/**/

		}


	
		void Közép(double meret, Color szin, Color szin2)
        {
            for (int i = 0; i < 6; i++)
            {
				Közepminta(100, szin, szin2);
			

            }


        }


		void FELADAT()
		{
			/**/
			Üres(110, Color.Green);
			Tollat(fel);
			Előre(2);
			Jobbra(1);
			Tollat(le);
			
			/**/

			Közép(100, Color.DarkGreen, Color.LightGreen);



		}
	}
}
