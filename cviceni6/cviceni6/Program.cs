using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni6
{
    class Program
    {

        static double GetPrize(double x) {
            return x;
        }
        static void Main(string[] args)
        {

            Library library = new Library();
            Librarian pepa = new Librarian("pepa",GetPrize);
            Librarian petr = new Librarian("petr",GetPrize);

            library.BookAdded += pepa.KnihaPridelena;
            library.BookAdded += petr.KnihaPridelena;

            library.add(new Book("kniha"));



            /*library.Add(new Book("ahoj")
            {
                Title = "kniha !"
            });*/
        }
    }
}
