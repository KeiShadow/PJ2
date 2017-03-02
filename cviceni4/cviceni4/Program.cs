
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tree = new Stack<int>();
            tree.Push(5);
            tree.Push(6);

            Stack<string> tree1 = new Stack<string>();
            tree1.Push("aaa");
            tree1.Push("bbb");

            Console.WriteLine(tree1.Pop());
            Console.WriteLine(tree1.Pop());
            Console.WriteLine(tree.Pop());
            Console.WriteLine(tree.Pop());


        }
    }
}