using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class SmallStack
    {
        //private void ove
       
        private int[] pole = new int[10];

        private int index=0;

        public void Push(int cislo)
        {
          
            if (index == pole.Length-1) throw new IndexOutOfRangeException("Prekrocena velkost");

            pole[index] = cislo;
            index++;
           
           
        }

        public int Pop()
        {
            if (index-1 < 0) throw new IndexOutOfRangeException("Nesmie byt menej ako nula");

            return pole[index--];
        }


    }
}
