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
    partial class Form1
    {
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


		}


		// Előre(10);


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









	}
}
