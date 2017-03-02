using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
           // MyArray array = new MyArray();
            //array[5] = "abc";
            int n = 10;
            DynamicArray<int?> array2 = new DynamicArray<int?>(5);
            array2[1] = 0;
            array2[5] = 0;
            Console.WriteLine(array2.status());
            Console.WriteLine(array2.ToString());
            Console.ReadLine();

        }
    }
}
