using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //ジェネリックの場合、インスタンス生成時に具体的な型に置き換えられる。
            //一つのクラスで異なる型に対応するインスタンスを作成できる。
            MyFIFO<int> intStack = new MyFIFO<int>();
            MyFIFO<string> strStack = new MyFIFO<string>();

            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            intStack.Push(4);

            Console.WriteLine(intStack.Pop());
            Console.WriteLine(intStack.Pop());
            Console.ReadLine();

            strStack.Push("a");
            strStack.Push("b");
            strStack.Push("c");
            strStack.Push("d");

            Console.WriteLine(strStack.Pop());
            Console.WriteLine(strStack.Pop());
            Console.ReadLine();

        }
    }

}
