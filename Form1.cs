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

		void Levél(double meret, Color szin)
        {
			Tollszín(szin);
            for (int i = 0; i < 19; i++)
            {
				Balra(5);
				Előre(1);
            }
			Jobbra(90);
            for (int i = 0; i < 13; i++)
            {
				Jobbra(8);
				Előre(0.75);

            }
			Jobbra(90);
            for (int i = 0; i < 12; i++)
            {
				Balra(8);
				Előre(0.75);

            }
			for (int i = 0; i < 4; i++)
			{
				Jobbra(20);
				Előre(1);

			}
			for (int i = 0; i < 3; i++)
			{
				Jobbra(10);
				Előre(2.5);

			}

			/**/
			Jobbra(160);
			Tollat(fel);
			Előre(6);
			Tollat(le);

			Tölt(szin);
			Tollat(fel);
			Előre(-6);
			Tollat(le);
			/**/



		}
		void Levél2(double meret, Color szin)
		{
			Tollszín(szin);
			for (int i = 0; i < 19; i++)
			{
				Balra(-5);
				Előre(1);
			}
			Jobbra(-90);
			for (int i = 0; i < 13; i++)
			{
				Jobbra(-8);
				Előre(0.75);

			}
			Jobbra(-90);
			for (int i = 0; i < 12; i++)
			{
				Balra(-8);
				Előre(0.75);

			}
			for (int i = 0; i < 4; i++)
			{
				Jobbra(-20);
				Előre(1);

			}
			for (int i = 0; i < 3; i++)
			{
				Jobbra(-10);
				Előre(2.5);

			}

			/**/
			Jobbra(-160);
			Tollat(fel);
			Előre(6);
			Tollat(le);

			Tölt(szin);
			Tollat(fel);
			Előre(-6);
			Tollat(le);
			/**/



		}



		void Fű(double meret, Color szin, Color szin2, Color szin3)
        {
			/**/
			Üres(meret, szin);
			Tollat(fel);
			Előre(2);
			Jobbra(0.5);
			Tollat(le);
			
			/**/

			Közép(100, szin2, szin3);

			Tollat(fel);
			Hátra(112.5);
			Tollat(le);





        }

		void Vege(Color szin, Color szin2, Color szin3)
        {Fű(110,szin,szin2,szin3);
			Jobbra(130);

			Levél(100, szin2);
			Balra(43.5);

			Tollat(fel);
			Előre(22);
			Balra(16);
			Balra(90);
			Előre(2);
			Jobbra(90);
			Tollat(le);
			Levél(100, szin2);

			for (int i = 0; i < 2; i++)
			{
				Balra(11*i*2);
            Tollat(fel);
			Előre(22);
			Balra(16);
			Balra(90);
			Előre(18);
			Jobbra(90);
			Tollat(le);
			Levél(100, szin2);
				Jobbra(10);

            }
			Tollat(fel);
			Előre(22);
			Balra(16);
			Balra(90);
			Előre(25);
			Jobbra(90);
			Hátra(5);
			Tollat(le);
			Levél(100, szin2);


			////
			///

			Tollat(fel);
			Balra(36);
			Hátra(70);
			Balra(90);
			Előre(30);
			Balra(90);
			Tollat(le);
			Jobbra(180);


			Jobbra(-150);


			Levél2(100, szin2);
			Balra(-50);
			/**/
			Tollat(fel);
			Előre(22);
			Balra(-28);
			Balra(-90);
			Előre(2);
			Jobbra(-90);
			Tollat(le);
			Levél2(100, szin2);
			/**/

			for (int i = 0; i < 2; i++)
			{
				Jobbra(20 * i * 2);
				Tollat(fel);
				Előre(28);
				Balra(-22);
				Balra(-90);
				Előre(18);
				Jobbra(-90);
				Tollat(le);
				Levél2(100, szin2);
				Jobbra(-20);

			}
			Tollat(fel);
			Előre(30);
			Balra(-24);
			Balra(-90);
			Előre(25);
			Jobbra(-90);
			Hátra(5);
			Tollat(le);
			Levél2(100, szin2);
			/**/



		}

		void FELADAT()
		{



			Vege(Color.Green, Color.DarkGreen, Color.LightGreen);



		}
	}
}
