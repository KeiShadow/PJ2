using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class MyArray
    {
        private string[] abc;
        public string this[int a] {
            get {
                return this.abc[a];
            }
            set
            {

                this.abc[a] = value;
            }
        }


    }
}
