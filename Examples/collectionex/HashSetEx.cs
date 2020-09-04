using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.collectionex
{
    class HashSetEx
    {
        public static void MainMethod(string[] args)
        {

            // Create a set of strings  
            //var names = new HashSet<string>() { "abc", "ijk", "lmn", "xyz" };

            //HashSet<string> names = new HashSet<string>();

            var names = new HashSet<string>();
            names.Add("abc");
            names.Add("fdf");
            names.Add("xyz");
            names.Add("ijk");
           // names.Add("abc");

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();

        }
    }
}
