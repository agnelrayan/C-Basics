using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.collectionex
{
    class ListEx
    {
        public static void MainMethod(string[] args)
        {
            // Create a list of strings using collection initializer 
            // var names = new List<string>() { "abc","ijk","xy"};
            var names = new List<string>();
            names.Add("Ag");
            names.Add("Ray");
            names.Add("Joe");
            names.Add("Jose");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
        
    }
}
