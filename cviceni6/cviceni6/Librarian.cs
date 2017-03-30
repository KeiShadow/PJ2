using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni6
{
    public delegate double GetPrize(double x);
    public class Librarian
    {
        public GetPrize prize;
        public string name;

        public Librarian(string name, GetPrize prize) {
            this.prize = prize;
            this.name = name;


        }
        public void KnihaPridelena(string name) {
            Console.WriteLine("Nazev knihy: " + name + " "+prize(20));
        }

        public double randomPrize(double x) {
            if (prize != null) {
                return prize(x);
            }
            return 0;
        }

        public string Name{
         get {
                return name;

            }
            set {
                name = value;

            }
        }

    }
}
