using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.collectionex
{
    class SorteddictEx
    {
        public static void MainMethod(string[] args)
        {
            SortedDictionary<string, string> names = new SortedDictionary<string, string>();
            names.Add("1","Ag");
            names.Add("4","ray");
            names.Add("5","ab");
            names.Add("3","xy");

            foreach (KeyValuePair<string,string> kv in names)
            {
                Console.WriteLine(kv.Key+" "+kv.Value);
            }

            Console.ReadKey();
        }

     
}
}
