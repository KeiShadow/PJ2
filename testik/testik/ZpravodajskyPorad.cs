using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testik
{
    class ZpravodajskyPorad : iPorad
    {
        double cena;
        int reklamy;

        public ZpravodajskyPorad(int reklamy, double cena)
        {
            Reklama = reklamy;
            Cena = cena;
        }

        public double Cena
        {
            get
            {
                return cena;
            }

            set
            {
                cena = value;
            }
        }

        public int Reklama
        {
            get
            {
                return reklamy;
            }

            set
            {
                reklamy = value;
            }
        }

        public override string ToString()
        {
            
           return ("Zpravodajstvi, reklamy: " + this.reklamy + ", cena: " + this.cena);
        }
    }
}
