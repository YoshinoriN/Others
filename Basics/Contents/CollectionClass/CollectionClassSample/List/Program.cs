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
            List<Person> list = new List<Person>();
            list.Add(new Person("山田"));
            list.Add(new Person("田中"));

            foreach (Person person in list)
            {
                Console.WriteLine(person.Name);
            }
            Console.ReadLine();
        }
    }
}
