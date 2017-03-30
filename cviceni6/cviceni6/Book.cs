using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni6
{
   public class Book
    {
        public string title;
        public string knihovnik;
        public Book(string title) {

            this.title = title;
        }
        public string Title
        {
            get {


                return title;
            }
          set {

                title = value;
            }
        }
    }
}
