using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.examples
{
    class FactEx
    {
        public static void MainMethod(string[] arg)
        {
            int fact = 1;
            int count = 5;
            for (int i=1;i<=count;i++)
            {

                fact = fact * i;

            }
            Console.WriteLine(fact);
            Console.ReadKey();
        }
    }
}
