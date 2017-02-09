using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Car
    {
       // private int A;
      //  private Dictionary<string, string> parts = new Dictionary<string, string>;
        //indexery
        public string this[string key]
        {
            get
            {
                return "moje kolo";
            }
            set
            {
                //parts[key] = value;
            }

        }



        /* public int B { get; set;}Bud takhle nebo:*/
        /* public int B
         {
             get
             {
                 return A;
             }
             set
             {
                 if (value < 0)
                 {
                     throw new Exception();
                 }
                 A = value;
             }
         }*/
    }
}
