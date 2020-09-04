using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.examples
{
    class MultEx
    {
        public static void MainMethod(string[] args)
        {
            int n = 5;
            for (int i=1;i<=10;i++)
            {
                Console.WriteLine(i+ "*"+n+ "=" +(i*n));
            }

            Console.ReadKey();
        }
    }
}
