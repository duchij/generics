using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class GenericSmallStack<T>
    {
        //private void ove

        private T[] pole = new T[10];

        private int index = 0;

        public void Push(T obj)
        {

            if (index == pole.Length - 1) throw new IndexOutOfRangeException("Prekrocena velkost");

            pole[index] = obj;
            index++;


        }

        public T Pop()
        {
            if (index - 1 < 0) throw new IndexOutOfRangeException("Nesmie byt menej ako nula");

            return pole[index--];
        }

       


    }

}
