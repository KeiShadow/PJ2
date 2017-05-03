using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIP
{
    class FireWall
    {

        public IList<Rule> Rules = new List<Rule>();

        public FireWall(string file)
        {
            using (FileStream files = new FileStream(file, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(files))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Replace(" ", "");
                        String[] pom = line.Split('-');
                        Rule myRule = new Rule(new IPAddress(pom[0], pom[1]), (pom[2] == "A") ? Access.Allow : Access.Denny);
                        Rules.Add(myRule);
                    }

                }
            }

        }

        public bool Test(string ip)
        {

            int trueValue = 0;
            int falseValue = 0;
            int i = Rules.Count;
            
            for (int j = 0; j < Rules.Count; j++)
            {
                Rule r = Rules[j];

                if (r.Network.IsInNetwork(ip))
                {
                    trueValue += i;
                    Rules[j].Test += 1;

                }
                else
                {
                    falseValue += i;
                }

                i--;


            }

            if (trueValue == falseValue)
            {
                throw new FireWallException(ip);
            }

            if (trueValue > falseValue)
                return true;

            return false;

        }
        public void Info() {
            foreach (Rule r in Rules)
            {
                Console.WriteLine(r.ToString());
            }
        }

    }
}
