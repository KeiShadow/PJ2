using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni8
{
    class Num : IComparer<double>
    {
        
        public int Compare(double x, double y)
        {
            if (x % 2 == 0)
            {
                return 0;
            }
            return (int)(x + y);
        }
    }
}
