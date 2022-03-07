using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
    public partial class Form1
    {
        #region Alap
        void Alap(double meret, Color szin)
        {
            //Bezier(100, 180, 100, 90, 141, false, false);
            Bezier(meret, 180, meret, 90, meret*1.5, false, false);
            Bezier(meret, 0, meret, 90, meret*1.5, false, false);
            using (new Rajzol(false))
            {
                Jobbra(90);
                Előre(meret / 4);
                Jobbra(90);
            }
            Bezier(meret*1.3, 180, meret*1.3, 90, meret*2, false, false);
            Bezier(meret*1.3, 0, meret*1.3, 90, meret*2, false, false);
            //Jobbra(90);
            //Előre(meret * 2);
            //Balra(90);
            using (new Rajzol(false))
            {
                //Hátra(10);
                Balra(90);
                Előre(meret/8);
                Balra(90);
            }
            Tölt(szin);
            using (new Rajzol(false))
            {
                //Hátra(10);
                Jobbra(90);
                Hátra(meret / 8);
                Jobbra(90);
            }
        }
        void Virágbelső(double meret, Color szín)
        {
            Tollszín(szín);
            Előre(meret * 0.1);
            for (int i = 0; i < 180; i++)
            {
                Előre(meret/100);
                Jobbra(1);
            }
            Előre(meret * 0.1);
            Jobbra(90);
            Előre(meret*1.156);
            /**/
            Jobbra(135);
            using (new Rajzol(false))
                Előre(meret / 10);
            Tölt(szín, false);
            using (new Rajzol(false))
                Hátra(meret / 10);
            Balra(135);
            /**/
        }
        void Virágkülső(double meret, Color szin)
        {
            Tollszín(szin);
            Balra(90);
            for (int j = 0; j < 9; j++)
            {
                for (int k = 0; k < 180; k++)
                {
                    Előre(meret / 1000);
                    Jobbra(1);
                }
                Balra(90);
                for (int i = 0; i < 20; i++)
                {
                    Előre(meret / 200);
                    Jobbra(1);
                }
                Balra(90);
            }
            for (int k = 0; k < 180; k++)
            {
                Előre(meret / 1000);
                Jobbra(1);
            }
            Előre(meret / 10);
            Jobbra(90);
            Előre(meret * 0.03);
            for (int i = 0; i < 180; i++)
            {
                Előre(meret * 0.009);
                Balra(1);
            }
            Előre(meret / 20);
            Jobbra(90);
            Előre(meret / 10);
            using (new Rajzol(false))
            {
                Jobbra(135);
                Előre(meret/40);
            }
            Tölt(szin, false);
            using (new Rajzol(false))
            {
                Hátra(meret/40);
                Balra(135);
            }
        }
        void Virág(double meret, Color szinbelso, Color szinkulso)
        {
            Virágbelső(meret*0.7, szinbelso);
            using (new Rajzol(false))
                Előre(meret/3);
            Jobbra(90);
            Virágkülső(meret*1.2, szinkulso);
        }
        void Viragfeletticuccli(double meret, Color szin)
        {
            Balra(260);
            for (int i = 0; i < 80; i++)
            {
                Előre(meret*0.005);
                Jobbra(1);
            }
            Jobbra(180);
            for (int i = 0; i < 80; i++)
            {
                Előre(meret*0.005);
                Jobbra(1);
            }
            Balra(150);
            for (int i = 0; i < 50; i++)
            {
                Előre(meret*0.005);
                Balra(1);
            }
            Jobbra(60);
            for (int i = 0; i < 50; i++)
            {
                Előre(meret*0.005);
                Balra(1);
            }
            using(new Rajzol(false))
            {
                Fordulj(160);
                Előre(meret/10);
            }
            Tölt(szin, false);
            using (new Rajzol(false))
            {
                Hátra(meret/10);
                Fordulj(90);
            }
            
        }
        void Finishedvirag(double meret, bool start)
        {
            if (start)
            {
                for (int i = 0; i < 2; i++)
                {
                    Virág(meret, Color.DarkGreen, Color.Black);
                    using (new Rajzol(false))
                    {
                        Előre(meret * 0.75);
                        Jobbra(90);
                        Előre(meret);
                    }
                    Viragfeletticuccli(meret * 2, Color.Black);
                    using (new Rajzol(false))
                    {
                        Hátra(meret);
                        Balra(90);
                        Előre(meret * 0.9167);
                    }
                    Jobbra(90);
                }
                Virág(meret, Color.DarkGreen, Color.Black);
                using (new Rajzol(false))
                {
                    Előre(meret * 2);
                    Jobbra(90);
                }

                for (int i = 0; i < 2; i++)
                {
                    Virág(meret, Color.DarkGreen, Color.Black);
                    using (new Rajzol(false))
                    {
                        Előre(meret * 0.75);
                        Jobbra(90);
                        Előre(meret);
                    }
                    Viragfeletticuccli(meret * 2, Color.Black);
                    using (new Rajzol(false))
                    {
                        Hátra(meret);
                        Balra(90);
                        Előre(meret * 0.9167);
                    }
                    Jobbra(90);
                }
                Virág(meret, Color.DarkGreen, Color.Black);
            }
            else if(!start)
            {
                Virág(meret, Color.DarkGreen, Color.Black);
				using (new Rajzol(false))
				{ Előre(meret); }
				Jobbra(90);
				Egész();
				Balra(90);
				using (new Rajzol(false))
					Előre(meret * 2);
                Jobbra(90);
                for (int i = 0; i < 2; i++)
                {
                    Virág(meret, Color.DarkGreen, Color.Black);
                    using (new Rajzol(false))
                    {
                        Előre(meret * 0.75);
                        Jobbra(90);
                        Előre(meret);
                    }
                    Viragfeletticuccli(meret * 2, Color.Black);
                    using (new Rajzol(false))
                    {
                        Hátra(meret);
                        Balra(90);
                        Előre(meret * 0.9167);
                    }
                    Jobbra(90);
                }
                Virág(meret, Color.DarkGreen, Color.Black);
				using (new Rajzol(false))
				{ Előre(meret); }
				Jobbra(90);
				Egész();
				Balra(90);
				using (new Rajzol(false))
					Előre(meret * 2);
				Jobbra(90);
				Virág(meret, Color.DarkGreen, Color.Black);

            }
        }
		#endregion
		#region Emese része

		void Külső_vonal_bal(double meret, Color szin)
		{
			Tollszín(szin);


			Balra(90);
			Bezier(meret / 2, 0, meret / 2, 80, meret, false, false);
			Jobbra(50);
			for (int i = 0; i < 10; i++)
			{
				Előre(1);
				Balra(1 + i);

			}

			Tollat(fel);
			Jobbra(5);
			Hátra(meret / 3.9);
			Jobbra(90);
			Hátra(meret / 0.975);

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
			Bezier(-meret / 2, 30, meret / 5, 100, meret, false, false);
			Jobbra(100);

			for (int i = 0; i < 10; i++)
			{
				Előre(1);
				Jobbra(1 + i);

			}
			Tollat(fel);
			Balra(5);
			Hátra(meret / 4);
			Balra(90);
			Hátra(meret / 0.975);

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


			Külső_vonal_bal_belül(meret * 0.85, szin);
			Külső_vonal_jobb_belül(meret * 0.85, szin);

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

		void Közepminta(double meret, Color szin, Color szin2)
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
		{
			Fű(110, szin, szin2, szin3);
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
				Balra(11 * i * 2);
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

			Tollat(fel);
			Jobbra(19);
			Hátra(70);
			Jobbra(90);
			Előre(32);
			Tollat(le);
			Jobbra(90);
			/**/



		}


		#endregion
		#region Peti része
		void szár_bal_nagy(Color szin)
		{
			Balra(90);
			Előre(5);
			Jobbra(70);

			Előre(10);

			Balra(90);
			Előre(5);
			Jobbra(120);
			Ív(80, 5);
			Balra(110);

			Balra(3);
			Előre(10);

			Balra(90);
			Előre(7);
			Jobbra(120);
			Ív(80, 7);
			Balra(110);

			Balra(3);
			Előre(10);

			Balra(90);
			Előre(10);
			Jobbra(120);
			Ív(80, 10);
			Balra(110);

			Balra(5);
			Előre(5);
			Balra(20);
			Előre(10);
			Balra(45);
			Előre(5);
			Jobbra(90);
			Ív(100, 8);

			Balra(170);
			Előre(15);
			Balra(45);
			Előre(12);
			Jobbra(45);
			Ív(100, 5);

			Balra(144);
			Előre(5);
			Balra(45);
			Előre(10);
			Balra(45);
			Előre(7);
			Balra(45);
			Előre(3);
			Balra(90);
			Előre(3);
			Jobbra(90);
			Előre(2);
			Jobbra(45);
			Előre(2);
			Jobbra(45);
			Előre(5);
			Jobbra(80);
			Előre(10);
			Jobbra(45);
			Előre(7);
			Jobbra(45);
			Előre(20);
			Jobbra(50);
			Előre(5);
			Ív(105, 30);
			Előre(50);
			Balra(140);

			Előre(50);

			Ív(105, 30);
			Jobbra(50);
			Előre(20);
			Jobbra(45);
			Előre(7);
			Jobbra(45);
			Előre(7);

			Jobbra(45);
			Előre(5);
			Jobbra(45);
			Előre(5);
			Jobbra(90);
			Előre(5);
			Jobbra(90);
			Előre(5);
			Balra(100);
			Előre(3);
			Balra(45);
			Előre(5);
			Balra(45);
			Előre(10);


			Balra(90);
			Előre(7);
			Jobbra(70);
			Előre(2);
			Jobbra(50);
			Előre(5);

			Balra(90);
			Előre(7);
			Balra(50);
			Előre(10);
			Balra(130);
			Ív(100, 7);
			Jobbra(135);
			Előre(3);
			Balra(70);
			Előre(10);
			Balra(65);
			Előre(15);

			Balra(110);
			Előre(10);
			Jobbra(90);
			Előre(7);
			Jobbra(120);
			Előre(5);
			Balra(45);
			Előre(5);
			Balra(45);
			Előre(5);

			Balra(100);
			Előre(7);
			Jobbra(130);
			Előre(7);
			Balra(45);
			Előre(7);

			Balra(90);
			Előre(5);
			Jobbra(130);
			Előre(10);
			Balra(40);

			Előre(12);
			Jobbra(70);
			Előre(13);

			Tollat(fel);
			Hátra(4);
			Jobbra(90);
			Előre(4);
			Tölt(szin);
			Előre(22);
			Tollat(le);

		}

		void kis_háromszög(Color szin)
		{
			Balra(10);
			Előre(15);
			Jobbra(100);
			Előre(5);
			Jobbra(100);
			Előre(15);
			Jobbra(170);

			Tollat(fel);
			Előre(10);
			Tölt(szin);
			Hátra(10);
			Tollat(le);

			Tollat(fel);
			Előre(25);
			Balra(90);
			Előre(7);
			Jobbra(90);
			Tollat(le);
		}

		void kishullám(Color szin)
		{
			Jobbra(55);
			Ív(80, 10);
			Balra(110);
			Előre(10);
			Balra(110);
			Előre(7);
			Jobbra(90);
			Bezier(5, -180, 5, -90, 5);
			Jobbra(85);
			Előre(8);
			Balra(110);
			Előre(10);

			Tollat(fel);
			Balra(70);
			Előre(7);
			Balra(90);
			Előre(5);
			Tölt(szin);
			Hátra(5);
			Tollat(le);

			Tollat(fel);
			Előre(15);
			Balra(90);
			Előre(18);
			Jobbra(90);
			Tollat(le);
		}

		void nagyhullám(Color szin)
		{
			Jobbra(45);
			Ív(60, 10);
			Balra(110);
			Ív(180, 10);
			Balra(100);
			Ív(60, 10);

			Balra(100);
			Előre(15);

			Tollat(fel);
			Hátra(15);
			Balra(125);
			Előre(40);
			Jobbra(90);
			Tollat(le);

			Balra(25);
			Előre(15);
			Jobbra(100);
			Előre(5);
			Balra(60);
			Ív(100, 10);
			Balra(90);
			Ív(120, 10);
			Balra(90);
			Ív(100, 10);
			Balra(20);
			Előre(6);

			Jobbra(70);
			Előre(15);
			Jobbra(65);
			Tollat(fel);
			Előre(22);
			Jobbra(90);
			Tollat(le);

			Tollat(fel);
			Előre(20);
			Tölt(szin);
			Előre(8);
			Előre(5);
			Tollat(le);

			Tollat(fel);
			Balra(90);
			Előre(15);
			Jobbra(90);
			Tollat(le);

		}

		void szár_bal_kicsi(Color szin)
		{
			Balra(45);
			Balra(3);
			Előre(10);

			Balra(90);
			Előre(7);
			Jobbra(120);
			Ív(80, 7);
			Balra(110);

			Balra(3);
			Előre(10);

			Balra(90);
			Előre(10);
			Jobbra(120);
			Ív(80, 10);
			Balra(110);

			Balra(5);
			Előre(5);
			Balra(20);
			Előre(10);
			Balra(45);
			Előre(5);
			Jobbra(90);
			Ív(100, 8);

			Balra(170);
			Előre(15);
			Balra(45);
			Előre(12);
			Jobbra(45);
			Ív(100, 5);

			Balra(144);
			Előre(5);
			Balra(45);
			Előre(10);
			Balra(45);
			Előre(7);
			Balra(45);
			Előre(3);
			Balra(90);
			Előre(3);
			Jobbra(90);
			Előre(2);
			Jobbra(45);
			Előre(2);
			Jobbra(45);
			Előre(5);
			Jobbra(80);
			Előre(10);
			Jobbra(45);
			Előre(7);
			Jobbra(45);
			Előre(20);
			Jobbra(50);
			Előre(5);
			Ív(105, 30);
			Előre(40);

			Jobbra(90);
			Előre(10);

			Tollat(fel);
			Hátra(5);
			Jobbra(90);
			Előre(5);
			Tölt(szin);
			Hátra(5);
			Balra(90);
			Hátra(5);

			Jobbra(50);
			Hátra(10);

			Jobbra(130);
			Előre(5);
			Tollat(le);
		}

		void szár_jobb_kicsi(Color szin)
		{
			Előre(33);

			Ív(105, 30);
			Jobbra(50);
			Előre(20);
			Jobbra(45);
			Előre(7);
			Jobbra(45);
			Előre(7);

			Jobbra(45);
			Előre(5);
			Jobbra(45);
			Előre(5);
			Jobbra(90);
			Előre(5);
			Jobbra(90);
			Előre(5);
			Balra(100);
			Előre(3);
			Balra(45);
			Előre(5);
			Balra(45);
			Előre(10);

			Balra(90);
			Előre(7);
			Jobbra(70);
			Előre(2);
			Jobbra(50);
			Előre(5);

			Balra(90);
			Előre(7);
			Balra(50);
			Előre(10);
			Balra(130);
			Ív(100, 7);
			Jobbra(135);
			Előre(3);
			Balra(70);
			Előre(10);
			Balra(65);
			Előre(15);

			Balra(110);
			Előre(10);
			Jobbra(90);
			Előre(7);
			Jobbra(120);
			Előre(5);
			Balra(45);
			Előre(5);
			Balra(45);
			Előre(5);

			Balra(100);
			Előre(7);
			Jobbra(130);
			Előre(7);
			Balra(45);
			Előre(7);

			Jobbra(90);
			Előre(12);

			Tollat(fel);
			Hátra(5);
			Jobbra(90);
			Előre(10);
			Tölt(szin);
			Hátra(12);
			Balra(90);

			Balra(45);
			Előre(10);
			Jobbra(90);

			Előre(10);
			Tollat(le);
		}

		void nagy_háromszög(Color szin)
		{
			Balra(20);
			Előre(15);
			Jobbra(100);
			Előre(10);
			Jobbra(115);
			Előre(15);
			Jobbra(165);

			Tollat(fel);
			Előre(10);
			Tölt(szin);
			Előre(5);
			Előre(10);
			Tollat(le);
		}

		void szirom(Color szin)
		{
			Tollat(fel);
			Balra(90);
			Előre(3);
			Jobbra(90);
			Tollat(le);

			Jobbra(30);
			Előre(3);
			Jobbra(120);
			Előre(3);
			Jobbra(120);
			Tollat(fel);
			Előre(3);
			Tollat(le);

			Jobbra(20);
			Előre(5);
			Balra(30);
			Tollat(fel);
			Előre(9);
			Tollat(le);
			Jobbra(120);
			Ív(110, 5);
			Balra(20);
			Jobbra(180);
			Balra(30);
			Tollat(fel);
			Előre(9);
			Tollat(le);
			Jobbra(90);
			Ív(70, 5);
			Balra(110);

			Előre(10);
			Balra(50);
			Előre(5);
			Jobbra(140);
			Előre(5);
			Balra(80);

			Előre(7);

			Balra(50);
			Előre(5);
			Jobbra(140);
			Előre(5);
			Balra(80);

			Jobbra(20);
			Előre(5);

			Balra(50);
			Előre(5);
			Jobbra(140);
			Előre(5);
			Balra(80);

			Jobbra(20);
			Előre(5);

			Balra(50);
			Előre(7);
			Jobbra(140);
			Előre(7);
			Balra(90);
			Ív(90, 15);


			Tollat(fel);
			Balra(10);
			Előre(10);
			Jobbra(7);

			Tollat(le);
			Ív(180, 20);
			Ív(150, 20);
			Tollat(fel);
			Jobbra(10);
			Előre(10);
			Balra(20);
			Tollat(le);
			Ív(90, 10);

			Balra(117);
			Előre(3);
			Jobbra(70);
			Előre(5);
			Jobbra(100);
			Előre(5);
			Balra(55);
			Előre(5);

			Balra(90);
			Előre(3);
			Jobbra(90);
			Előre(3);
			Jobbra(100);
			Előre(5);
			Balra(70);

			Előre(5);

			Balra(90);
			Előre(5);
			Jobbra(130);
			Előre(7);
			Balra(25);

			Előre(5);

			Balra(90);
			Előre(5);
			Jobbra(130);
			Előre(7);
			Balra(20);

			Előre(10);

			Balra(80);
			Előre(5);
			Jobbra(140);
			Előre(7);
			Balra(25);

			Jobbra(10);
			Előre(7);

			Tollat(fel);
			Előre(3);
			Tollat(le);

			Jobbra(95);

			Tollat(fel);
			Előre(4);
			Tölt(szin);
			Előre(10);
			Tollat(le);
		}

		void Középső_szirom(Color szin)
		{
			Tollszín(szin);
			Tollvastagság(5);
			Tollat(fel);
			Balra(90);
			Előre(5);
			Jobbra(90);
			Tollat(le);

			Balra(50);
			Ív(100, 20);

			Tollat(fel);
			Jobbra(40);
			Előre(10);
			Jobbra(35);
			Tollat(le);

			Ív(100, 20);
			Ív(80, 10);
			Tollvastagság(1);
			Tollszín(Color.Black);

			Jobbra(55);
			Jobbra(90);
			Tollat(fel);
			Előre(5);
			Balra(90);
			Előre(5);
			Tollat(le);
		}

		void kisvirág(Color szin)
		{
			Tollat(fel);
			Előre(5);
			Jobbra(90);
			Előre(5);
			Jobbra(90);
			Tollat(le);

			Ív(180, 5);
			Előre(10);
			Balra(45);
			Előre(5);
			Jobbra(135);
			Előre(17);
			Jobbra(135);
			Előre(5);
			Balra(45);
			Előre(10);

			Tollat(fel);
			Jobbra(90);
			Előre(5);
			Balra(90);
			Előre(5);
			Jobbra(180);
			Tollat(le);

			Tollat(fel);
			Előre(10);
			Tölt(szin);
			Előre(22);
			Tollat(le);
		}

		void nagyvirág(Color szin)
		{
			Tollat(fel);
			Előre(5);
			Jobbra(90);
			Előre(5);
			Jobbra(90);
			Tollat(le);

			Ív(180, 5);
			Balra(20);
			Előre(10);
			Balra(55);
			Előre(5);
			Jobbra(165);
			Előre(10);
			Balra(45);
			Előre(5);
			Jobbra(90);
			Előre(5);
			Balra(45);
			Előre(10);
			Jobbra(160);
			Előre(5);
			Balra(40);
			Előre(10);

			Balra(30);
			Tollat(fel);
			Jobbra(90);
			Előre(5);
			Balra(90);
			Előre(5);
			Jobbra(180);
			Tollat(le);

			Tollat(fel);
			Előre(10);
			Tölt(szin);
			Tollat(le);
		}

		void helyedre()
		{
			Tollat(fel);
			Jobbra(90);
			Hátra(1);
			Balra(90);
			Hátra(204);
			Tollat(le);
		}
		void Egész()
        {
			szár_bal_nagy(Color.Black);

			kis_háromszög(Color.Black);

			kishullám(Color.DarkGreen);

			nagyhullám(Color.Black);

			szár_bal_kicsi(Color.DarkGreen);

			szár_jobb_kicsi(Color.DarkGreen);

			nagy_háromszög(Color.DarkGreen);

			szirom(Color.Black);

			Középső_szirom(Color.DarkGreen);

			kisvirág(Color.Black);

			nagyvirág(Color.DarkGreen);

			helyedre();
		}
		#endregion
	}
}
