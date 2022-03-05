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
        #region Harfa
        void Harfa(double meret, Color szin)
        {
            Tollszín(szin);
            Jobbra(90);
            Bezier(meret * 0.35, 90, meret * 0.65, 80, meret * 1.5, false, false);
            Balra(90);
            Bezier(meret * 0.65, 90, meret * 0.35, 280, meret * 1.5, false, false);
            Jobbra(90);
            using (new Rajzol(false))
                Előre(meret*0.535);
            Jobbra(90);
            Jobbra(90);
            Bezier(meret * 0.3, 90, meret * 0.8, 80, meret * 1.58, false, false);
            Balra(90);
            Bezier(meret * 0.8, 90, meret * 0.3, 280, meret * 1.58, false, false);
            Fordulj(-50);
            using (new Rajzol(false))
            {
                Előre(meret / 10);
            }
            Tölt(szin);
            using (new Rajzol(false))
                Hátra(meret / 10);
            Fordulj(50);
            Tollszín(Color.Black);
            /** /  
            /**/
        }
        #endregion
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
            Jobbra(130);
            for (int i = 0; i < 180; i++)
            {
                Előre(meret/200);
                Jobbra(1);
            }
            Jobbra(90);
            Előre(meret * 0.58);
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
        void alap_viragbelso(double meret, Color szinviragbelso, Color szinalap)
        {
            //Alap(meret, szinalap);
            for (int i = 0; i < meret*0.06; i++)
            {
                for (int j = 0; j < meret; j++)
                {
                    using (new Rajzol(false))
                        Előre(meret / 200);
                    Balra(1);
                }

                Virágbelső(meret / 2, szinviragbelso);
            }
        }
    }
}
