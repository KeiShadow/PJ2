using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni8
{
    class Calendar2 : IEnumerable<DateTime>
    {
        public IEnumerator<DateTime> GetEnumerator()
        {
            DateTime now = DateTime.Now;
            DateTime firstday = new DateTime(now.Year, now.Month, 1);
            DateTime lastDay = firstday.AddMonths(1);
            while (firstday < lastDay) {
                yield return firstday;
                firstday = firstday.AddDays(1);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            DateTime now = DateTime.Now;
            DateTime firstday = new DateTime(now.Year, now.Month, 1);
            DateTime lastDay = firstday.AddMonths(1);
            while (firstday < lastDay)
            {
                yield return firstday;
                firstday = firstday.AddDays(1);
            }
        }
    }
}
