using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.collectionex
{
    class StackEx
    {
        public static void MainMethod(string[] args)
        {
            Stack<string> names = new Stack<string>();
            names.Push("Sibu");
            names.Push("Peter");
            names.Push("James");
            names.Push("Ratan");
            names.Push("Irfan");
            
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek element: " + names.Peek());
            Console.WriteLine("Pop: " + names.Pop());
            Console.WriteLine("After Pop, Peek element: " + names.Peek());
            Console.ReadKey();

        }
    }
}
