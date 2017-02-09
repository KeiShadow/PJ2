using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExternalLib;
namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {


            Car alfa = new Car();
            // alfa.B = 6;
            string a = alfa["kolo"];
            Console.WriteLine(a);

            calc suma = new calc();
            suma.A = 5;
            suma.B = 1;
            Console.WriteLine(suma.Result);


            //string[] word = new string [args.Length];
            
          /*  for (int i = 0; i < args.Length; i++)
            {
                //word[i] = args[i];
                if (args[i].ToString().ToLower() == args[i].ToString())
                {
                    args[i] = args[i].ToUpper();
                    
                }
                else args[i] = args[i].ToLower();
                Console.WriteLine(args[i]);
            } */
        }
    }
}
