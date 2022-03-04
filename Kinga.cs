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
        }
        void Harfa(double meret, Color szin)
        {
            Bezier(50, 270, 50, 180, 150, false, false);
        }
    }
}
