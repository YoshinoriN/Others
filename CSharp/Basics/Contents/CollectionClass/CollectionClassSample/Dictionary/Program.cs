using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //インスタンス生成
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");

            Console.WriteLine(dict[1]);
            Console.WriteLine(dict[2]);
            Console.WriteLine(dict[3]);

            Console.ReadLine();

            //全ての要素を取り出す。
            foreach (KeyValuePair<int,string> keyV in dict)
            {
                Console.WriteLine(keyV.Value);
            }
            Console.ReadLine();
        }
    }
}
