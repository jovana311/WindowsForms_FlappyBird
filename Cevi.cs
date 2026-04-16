using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Cevi
    {
        Rectangle gornji;
        Rectangle donji;
        bool osvojenpoen;
        int pomeraj = 10;
        public int DohvatiXKoordinatuGornje()
        {
            return gornji.X;
        }
        public int DohvatiXKoordinatuDonje()
        {
            return donji.X;
        }
        public void PromeniX(ref int poeni, int pticaX) //kretanje cevi
        {
            this.gornji.X -= pomeraj;
            this.donji.X -= pomeraj;

            if (!osvojenpoen && (this.gornji.X+this.gornji.Width)<pticaX) //poeni
            {
                osvojenpoen = true;
                poeni++;

            }

        }
        public void NapraviPar(Graphics g, int visinaptice, int sirinaplatna) //kreira lokacije cevi/stubova, gornjeg i donjeg
        {
            Pen olovka = new Pen(Color.Black);
            Brush oboji = new SolidBrush(Color.SeaGreen);

            Random rand = new Random();

            int br = rand.Next(1, 5); //pet mogucih kombinacija, tj visina otvora kroz koji ptica prolazi
            int visinagornjeg;
            int pocetakdonjeg;
            switch (br)
            {
                case 1:
                    visinagornjeg = 0;
                    pocetakdonjeg = visinagornjeg + visinaptice + 5;
                    Rectangle[] stub1 =
                    {

                     new Rectangle(sirinaplatna, 0, 60, 0),
                     new Rectangle(sirinaplatna,   150, 60, 500)

                    };
                    this.gornji = stub1[0];
                    this.donji = stub1[1];
                    break;
                case 2:
                    visinagornjeg = 100;
                    pocetakdonjeg = visinagornjeg + visinaptice + 5;
                    Rectangle[] stub2 =
                        {

                     new Rectangle(sirinaplatna, 0, 60, 100),
                     new Rectangle(sirinaplatna,   250,  60, 500)
                    };

                    this.gornji = stub2[0];
                    this.donji = stub2[1];
                    break;
                case 3:
                    visinagornjeg = 200;
                    pocetakdonjeg = visinagornjeg + visinaptice + 5;
                    Rectangle[] stub3 =
                        {

                     new Rectangle(sirinaplatna, 0, 60, 200),
                     new Rectangle(sirinaplatna,   350,  60, 500)
                    };

                    this.gornji = stub3[0];
                    this.donji = stub3[1];
                    break;
                case 4:
                    visinagornjeg = 300;
                    pocetakdonjeg = visinagornjeg + visinaptice + 5;
                    Rectangle[] stub4 =
                            {

                     new Rectangle(sirinaplatna, 0, 60, 250),
                     new Rectangle(sirinaplatna,   400,  60, 500)
                    };

                    this.gornji = stub4[0];
                    this.donji = stub4[1];
                    break;
                case 5:
                    visinagornjeg = 350;
                    pocetakdonjeg = visinagornjeg + visinaptice + 5;
                    Rectangle[] stub5 =
                        {

                     new Rectangle(sirinaplatna, 0, 60, 300),
                     new Rectangle(sirinaplatna,   550,  60, 500)
                    };

                    this.gornji = stub5[0];
                    this.donji = stub5[1];
                    break;
            }

        }

        public bool Sudaranje(Point lokacijaPtice, int sirinaptice, int visinaptice) //ako ptica udari u stub
        {
            if((((this.gornji.X<=lokacijaPtice.X) && (lokacijaPtice.X <= this.gornji.X+ this.gornji.Width)) ||
                ((this.gornji.X<= lokacijaPtice.X+sirinaptice) && (lokacijaPtice.X + sirinaptice<= this.gornji.X+this.gornji.Width))) 
                &&((lokacijaPtice.Y<= this.gornji.Y+this.gornji.Height)||(lokacijaPtice.Y+visinaptice>this.donji.Y)))
                 return true;
            else return false;
        }

        public void Iscrtaj(Graphics g) //iscrtava cevi/stubove gornji i donji
        {

            Pen olovka = new Pen(Color.Black);
            Brush oboji = new SolidBrush(Color.SeaGreen);

            g.DrawRectangle(olovka, this.gornji); 
            g.FillRectangle(oboji, this.gornji);


            g.DrawRectangle(olovka, this.donji);
            g.FillRectangle(oboji, this.donji);
        }
    }
}
