using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni8
{
    class DayEnumerator : IEnumerator<DateTime>
    {
        private DateTime firstDayOfMonth;
        private DateTime? currentDay;
        public DayEnumerator(DateTime firstDayOfMonth) {
           

        }
        public DateTime Current {
            get{
                
                return this.currentDay.Value;
            }


        }
        //Vraci aktualni prvek

        object IEnumerator.Current
        {
            get
            {
                return this.currentDay.Value;
            }

        }

        //Vraci aktualni prvek toto zpetna kompatibilita

        public void Dispose()//Uvolneni zdroju(souboru), pokud je pouzivam
        {
        }

        public bool MoveNext() //nejdrive se vola move next vraci true false,
        {
            if (this.currentDay == null)
            {
                this.currentDay = this.firstDayOfMonth;
                return true;
            }
            else {
                if (this.currentDay.Value >= this.firstDayOfMonth.AddMonths(1).AddDays(-1)) {
                    return false;
                }   
                this.currentDay = this.currentDay.Value.AddDays(1);
            }
            return true;
        }

        public void Reset()// Vrati se na zacatek
        {
            this.currentDay = null;
        }
    }
}
