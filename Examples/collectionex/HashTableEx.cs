using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.collectionex
{
    class HashTableEx
    {
        public static void MainMethod(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("001", "Zara");
            ht.Add("002", "Abida");
            ht.Add("003", "Joe");
            ht.Add("004", "Benazir");
            ht.Add("005", "Amla");
            ht.Add("006", "Arif");
            ht.Add("007", "Ritesh");

            //if (ht.ContainsValue("Zara"))
            //{
            //    Console.WriteLine("This student name is already in the list");
            //}
            //else
            //{
            //    ht.Add("008", "Nuha");
            //}

            // Get a collection of the keys.
            //foreach (KeyValuePair<string, string> kv in ht)
            //{
            //    Console.WriteLine(kv.Key + " " + kv.Value);
            //}

            ICollection key = ht.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
            Console.ReadKey();
        }
    }
    }

