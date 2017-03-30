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
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string text = "Ahoj světe jak se máš?";
            string[] words = text.Split(' ');

            dict["Ahoj"] = "Hello";
            dict["světe"] = "world";
            dict["jak"] = "how";
            dict["se"] = "are";
            dict["máš?"] = "you?";

            foreach (string word in words) {
                Console.Write(dict[word]);
                Console.Write(" ");
            }




            /*
                        Dictionary<string, bool> dict = new Dictionary<string, bool>();


                        dict["ahoj"] = true;
                        dict["tome"] = false;

                        if (dict.ContainsKey("tome") && dict["tome"]) {
                            Console.WriteLine("jop");
                        }


                       double[] numbers = new double[10];
                       for (int i = 0; i < 10; i++) {
                           numbers[i] = i;
                       }

                       Array.Sort(numbers, new Num());

                       foreach (int num in numbers )
                       {
                           Console.WriteLine(num);
                       }

                       Calendar cal = new Calendar();
                       Calendar2 cal2 = new Calendar2();

                       foreach (DateTime date in cal2) {
                           Console.WriteLine(date);
                       }*/
        }
    }
}
