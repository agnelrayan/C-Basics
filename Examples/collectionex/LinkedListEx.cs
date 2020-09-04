using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.collectionex
{
    class LinkedListEx
    {
        public static void MainMethod(string[] args)
        {
            // Create a list of strings  
            var names = new LinkedList<string>();
            names.AddLast("Siah");
            names.AddLast("Arun");
            names.AddLast("Peter");
            names.AddLast("Irfan");
            names.AddFirst("John");//added to first index  

            // Iterate list element using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            //insert new element before "Peter"  
            LinkedListNode<String> node = names.Find("Peter");
            names.AddBefore(node, "Johny");
            names.AddAfter(node, "Lucy");

            Console.WriteLine("Iterate after adding...");
            // Iterate list element using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
