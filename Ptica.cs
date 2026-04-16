using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    class Ptica
    {
        PictureBox pbx;
        int brzinaY = 0;
        const int maxBrzina = 16;
        public Ptica(PictureBox Pbx) //povezuje pbxPticu iz forme u ovu klasu
        {
            pbx = Pbx;
        }
        public void Pomeri() //kretanje nanize
        {
            pbx.Location = new Point(pbx.Location.X, pbx.Location.Y - brzinaY);
            if(brzinaY > -maxBrzina)
            {
                brzinaY -= 2;
            }
        }
        public void Poleti() //skok
        {
            brzinaY = maxBrzina;
        }
    }
}
