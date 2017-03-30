using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("AHOJ");
            int a, b;
            a = 0;
            b = 0;
            for(int i = 0; i <= 20; i++)
            {
                a += i + b;
                b -= i + a;
                
            }
            System.Console.WriteLine(a+" , "+b);
        }
    }
}
