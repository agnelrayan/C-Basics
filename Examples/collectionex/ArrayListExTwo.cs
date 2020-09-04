using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.collectionex
{
    class ArrayListExTwo
    {
        public static void MainMethod(string[] args)
        {
            var al = new SortedSet <string>();
            //var names = new List<string>();

            al.Add("xyz");
            al.Add("abc");
            al.Add("lmn");
            //al.Add(12);
            //al.Add(23.23);
            //al.Add(true);
            al.Add("ijk");
            al.Add("ijk");
            al.Add(null);

            foreach (var j in al)
            {
                Console.WriteLine(j);
            }


            //Console.WriteLine("Capacity of collection: "+al.Capacity);
            //Console.WriteLine("Index of: "+al.IndexOf("abc"));//1
            //al.Remove("xyz");

            //Console.WriteLine("AFter Removing:");
            //foreach (var j in al)
            //{
            //    Console.WriteLine(j);
            //}

            //Console.ReadKey();

            //al.Reverse();

            //Console.WriteLine("Reverse the collections: ");

            //foreach (var j in al)
            //{
            //    Console.WriteLine(j);
            //}


            //al.Sort();

            //Console.WriteLine("Sort  the collections: ");
            //foreach (var j in al)
            //{
            //    Console.WriteLine(j);
            //}

        }
    }
}
