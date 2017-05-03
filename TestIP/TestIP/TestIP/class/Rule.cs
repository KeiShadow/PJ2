using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIP
{
    public class Rule
    {
        public IPAddress Network { get; set; }
        public Access Type { get; set; }
        public int Test { get; set; }

        public Rule(IPAddress ip, Access ac)
        {
            Network = ip;
            Type = ac;
        }

        public override string ToString()
        {
            return "IP: " + Network.IPC + ", " + Network.maska + " bylo uspesne" + Test.ToString() + " krat.";
        }
    }
}
