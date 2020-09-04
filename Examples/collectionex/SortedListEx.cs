using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.collectionex
{
    class SortedListEx
    {
        public static void MainMethod(string[] args)
        {
            SortedList<string, string> names = new SortedList<string, string>();


            names.Add("1", "Siah");
            names.Add("4", "Peter");
            names.Add("5", "James");
            names.Add("3", "Ratan");
            names.Add("2", "Irfan");
            foreach (KeyValuePair<string, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }

            Console.ReadKey();
        }
    }

}
