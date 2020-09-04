using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.collectionex
{
    class Sortedex
    {
        public static void MainMethod(string[] args)
        {
            // Create a set of strings  
           // var names = new SortedSet<string>() { "ijk", "abc", "xyz", "lmn" };
            // Create a set of strings  
            SortedSet<string> names = new SortedSet<string>();
            names.Add("ijk");
            names.Add("abc");
            names.Add("xyz");
            names.Add("lmn");
            names.Add("abc");//will not be added  

            // Iterate SortedSet elements using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}