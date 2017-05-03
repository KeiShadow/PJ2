using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIP
{
    class Program
    {
        
        static void Main(string[] args)
        {
            FireWall fr = new FireWall("rules.txt");
            Console.WriteLine(fr.Test("192.168.10.100"));
            Console.WriteLine(fr.Test("192.168.11.100"));
            Console.WriteLine(fr.Test("192.168.11.100"));
            fr.Info();
        }
    }
}
