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
            double[] numbers = new double[10];
            for (int i = 0; i < 10; i++) {
                numbers[i] = i;
            }

            Array.Sort(numbers, new Num());

            foreach (int num in numbers )
            {
                Console.WriteLine(num);
            }
            /*
            Calendar cal = new Calendar();
            Calendar2 cal2 = new Calendar2();

            foreach (DateTime date in cal2) {
                Console.WriteLine(date);
            }*/
        }
    }
}
