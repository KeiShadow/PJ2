using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni6
{
    public delegate void  OnBookAdded(string tittle);
    public class Library
    {
        public List<Book> kniha = new List<Book>();
        public OnBookAdded BookAdded;
        public void add(Book name) {

           this.kniha.Add(name);
            if (this.BookAdded != null) {

                this.BookAdded(name.title);

            }
        }


    }
}
