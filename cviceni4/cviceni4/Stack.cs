using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviko5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Stack<T>
    {
        private int pointer = -1;
        private T[] stack;

        public Stack()
        {
            this.stack = new T[15];
        }

        public void Clear()
        {
            this.pointer = -1;
        }

        public bool isEmpty()
        {
            return this.pointer == -1;
        }

        public bool isFull()
        {
            return this.pointer == this.stack.Length - 1;
        }

        public T Pop()
        {
            if (this.pointer > -1 && this.pointer <= 15)
            {
                T tmp = this.stack[this.pointer];
                this.pointer--;
                return tmp;
            }
            else
            {
                throw new ApplicationException();
            }
        }

        public void Push(T number)
        {
            if (this.pointer <= 15)
            {
                this.pointer++;
                this.stack[this.pointer] = number;
            }
            else
            {
                throw new ApplicationException();
            }
        }

        public T Top()
        {
            return this.stack[this.pointer];
        }
    }


}