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
        #region alap_viragbelso
        void alap_viragbelso(double meret, Color szinviragbelso, Color szinalap)
        {
            //Alap(meret, szinalap);
            for (int i = 0; i < meret * 0.06; i++)
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
            Tölt(szín);
            using (new Rajzol(false))
                Hátra(meret / 10);
            Balra(135);
            /**/
        }
        void Virágkülső(double meret, Color szin)
        {
            //Tollszín(szin);
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
                Előre(meret / 10);
            }
            Tölt(szin);
            using (new Rajzol(false))
            {
                Hátra(meret / 10);
                Balra(135);
            }
        }
        void Virág(double meret, Color szinbelso, Color szinkulso)
        {
            Virágbelső(meret*0.8, szinbelso);
            using (new Rajzol(false))
                Előre(meret/4);
            Jobbra(90);
            Virágkülső(meret*1.2, szinkulso);
        }
    }
}
