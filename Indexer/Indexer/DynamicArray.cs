using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class DynamicArray<T>
    {
        private T[] array;
        int newSize;
        int count;
        public DynamicArray(int n) {

            this.array = new T[n];

        }

        public T this[int a]{
            get {
                return this.array[a];
            }
            set {
                if (a >= this.array.Length) {
                    T[] newValues = new T[a + 1];
                    Array.Copy(array, newValues, array.Length);
                    this.array = newValues;
                }
                this.array[a] = value;
            }
            
        }
        public override string ToString()
        {
            return string.Join(",", this.array);
        }

        public int read
        {
         get {
                return this.array.Length;
            }    
        }

        public int Write
        {
            set
            {
                if (value >= this.array.Length) {
                    T[] newValues = new T[value];
                    Array.Copy(array, newValues, array.Length);
                    this.array = newValues;
                }
                else
                {
                    throw new ApplicationException();
                }

            }
        }

        public string status()
        {
            
            for (int i = 0; i < this.array.Length; i++) {

                if (array[i] == null) {
                    count += 1;
                }
            }
            if (count == this.array.Length)
            {

                return "Pole je plne";
            }
            else if (count == 0)
            {
                return "pole je prazdne";
            }
            else if (count < this.array.Length)
            {
                return "Poloprazdne";

            }
            return "";
        }
    }
}
