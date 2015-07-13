using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class MyFIFO<T>
    {
        private int size = 0;
        private T[] items;

        public MyFIFO()
        {
            items = new T[10];
        }

        public void Push(T x)
        {
            items[size++] = x;
        }

        public T Pop()
        {
            T y = items[0];
            //LINQで配列を作り直す。
            items = items.Skip(1).ToArray();
            return y;
        }
    }
}
