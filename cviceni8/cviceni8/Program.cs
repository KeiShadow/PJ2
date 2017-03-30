using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni8
{
    class Program
    {
        static void Main(string[] args)
        {

            Calendar cal = new Calendar();
            Calendar2 cal2 = new Calendar2();

            foreach (DateTime date in cal2) {
                Console.WriteLine(date);
            }
        }
    }
}
