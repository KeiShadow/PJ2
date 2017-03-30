using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udalostiadelegace
{
    class Program
    {
        public delegate void MyDelegate(int a, int b);
        public static void Sum(int a, int b) {
            Console.WriteLine(a + b);
        }

        public static void Diff(int a, int b)
        {
            Console.WriteLine(a - b);
        }

      /*  public static int Execute(MyDelegate fn, int a, int b)
        {
           //return fn(a, b));
        }*/
        static void Main(string[] args)
        {
            MyDelegate myFn;
            myFn = Sum;
            myFn += Diff;

            myFn(2, 3);


            //Console.WriteLine(Execute(Sum, 2, 4));
            //Console.WriteLine(Execute(Diff, 2, 4));
        }
    }
}
