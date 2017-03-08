using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testik
{
    class TelevizniKanal
    {
        private iPorad[] array;

        public TelevizniKanal(int a = 10) {
            this.array = new iPorad[a];
        }

        public iPorad this[int a] {
            get {
                return this.array[a];
            }
            set
            {
               
                if ((a >= this.array.Length))
                {
                    throw new IndexOutOfRangeException();
                }
                else this.array[a] = value;
            }
           }




        public double Zisk()
        {
            double x = 0;
            for (int i = 0; i < array.Length; i++) {
                if (array[i] != null) x = x + (array[i].Cena * array[i].Reklama);
            }
            return x;
        }

        public override string ToString()
        {
            for (int i = 0; i < array.Length; i++) {
                if (array[i] == null) Console.WriteLine("Nenastaveno");
                else Console.WriteLine(array[i].ToString());
            }
            Console.WriteLine("Zisk: " +Zisk());
            return null;
        }
    }
    
}

