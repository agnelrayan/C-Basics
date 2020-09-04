using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.collectionex
{
    class QueueEx
    {
        public static void MainMethod(string[] args)
        {
            Queue<string> names = new Queue<string>();
            names.Enqueue("Siah");
            names.Enqueue("Peter");
            names.Enqueue("James");
            names.Enqueue("Ratan");
            names.Enqueue("Irfan");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek element: " + names.Peek());
            Console.WriteLine("Dequeue: " + names.Dequeue());
            Console.WriteLine("After Dequeue, Peek element: " + names.Peek());
        }
    }
}
