using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni8
{
    class Calendar : IEnumerable<DateTime>
    {
        public IEnumerator<DateTime> GetEnumerator()
        {
            DateTime now = DateTime.Now;
            return new DayEnumerator(new DateTime(now.Year,now.Month,1));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            DateTime now = DateTime.Now;
            return new DayEnumerator(new DateTime(now.Year, now.Month, 1));
        }
    }
}
