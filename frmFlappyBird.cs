using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmFlappyBird : Form
    {
        public Graphics g;


        Ptica ptica;
        public int poeni = 0;
        public int brzina = 1;

        List<Cevi> trenutnistubovi = new List<Cevi>();
       
        public frmFlappyBird()
        {
            InitializeComponent();
            ptica = new Ptica(pbxPtica);
        }


        private void btnPocetak_Click(object sender, EventArgs e) //pocetak igre
        {
            
            g = pbxPozadina.CreateGraphics();
            trenutnistubovi.Clear(); //obezbedjivanje praznog pictureBox-a svaki put kad se pokrene igra

            pbxPozadina.Size = this.Size;

            //podesavanja za pticu
            tmrKretanjePtice.Start();
            pbxPtica.Left = pbxPozadina.Width / 2 - 50;
            pbxPtica.Top = pbxPozadina.Height / 2;
            pbxPtica.Visible = true;


            btnPocetak.Visible = false;

            //tajmeri za stvaranje i kretanje cevi
            tmrIgra.Start();
            tmrKretanjeCevi.Start();

            poeni = 0;
            tbxPoeni.Text = "Osvojen broj poena";

        }

        private void tmrKretanjePtice_Tick(object sender, EventArgs e) //ptica ce se kretati nanize automatski
        {
            ptica.Pomeri();
            
            if (pbxPtica.Top <= pbxPozadina.Top || pbxPtica.Bottom >= pbxPozadina.Bottom) //ako premasi granice ekrana
                    KrajIgre();
        }

        public void KrajIgre() //zaustavlja sve tajmere, objavljuje korisniku da je kraj igre i nudi da pokrene ponovo
        {
            tmrIgra.Stop();
            tmrKretanjePtice.Stop();
            tmrKretanjeCevi.Stop();
            MessageBox.Show("Kraj igre! " +
                "Broj osvojenih poena: " + poeni);
            btnPocetak.Visible = true;
            pbxPtica.Visible = false;
        }


        private void tmrIgra_Tick(object sender, EventArgs e) //pravljenje cevi na odredjeni interval
        {
            Cevi cev = new Cevi();
            cev.NapraviPar(g, pbxPtica.Height, pbxPozadina.Width);

            trenutnistubovi.Add(cev); //svaki napravljen par cevi/stubova se smesta u listu
             

        }

        private void timerKretanjeCevi_Tick(object sender, EventArgs e) //kretanje
        {

            for (int i = 0; i < trenutnistubovi.Count; i++)
            {
                Cevi stubovi = trenutnistubovi[i];

                if (stubovi.DohvatiXKoordinatuGornje() > 0) //ako nije cev vec prosla ekran
                {
                    stubovi.PromeniX(ref poeni, pbxPtica.Location.X); //pomera je
                    tbxPoeni.Text = "Osvojen broj poena: " + poeni; //ispisuje novi broj poena

                    Point lokacijaPtice = new Point(pbxPtica.Location.X, pbxPtica.Location.Y);
                    if (stubovi.Sudaranje(lokacijaPtice, pbxPtica.Width, pbxPtica.Height))//proverava da li je ptica udarila u stubove/cevi
                    {
                        KrajIgre();
                    }
                }

                if (stubovi.DohvatiXKoordinatuDonje()<0) trenutnistubovi.Remove(stubovi); //ako je cev prosla ekran, uklanja se iz liste

            }
            pbxPozadina.Invalidate(); 

        }



        private void pbxPozadina_Paint(object sender, PaintEventArgs e)//iscrtava cevi 
        {
            foreach (Cevi cevi in trenutnistubovi)
            {
                cevi.Iscrtaj(g);
            }
        }

        private void pbxPozadina_MouseClick(object sender, MouseEventArgs e) //jedna od kontrola je klik misem
        {
            ptica.Poleti();
        }



        private void uputstvo_MouseClick(object sender, MouseEventArgs e) 
        {
            string poruka = "Ptičicu je potrebno provesti izmedju cevi bez da ih u letu zakači. " +
                    "Kontrolišete je klikom na pozadinu, tasterom za razmak (space) ili strelicom navise." +
                    "Cilj je leteti što duže i osvojiti što više poena.";
            string naslov = "Uputstvo";
            MessageBox.Show(poruka, naslov);
            
        }

       
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //hvata ukucan taster i omogucava da
            //se koriste i space i strelica navise kao kontrole
        {
            if (keyData == Keys.Up || keyData == Keys.Space)
            {
                ptica.Poleti(); 
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
