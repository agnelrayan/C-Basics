using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.examples
{
    class FiboEx
    {
        public static void MainMethod(string[] arg)
        {
            int count = 5;// 1 1 2 3 5 8;
            int n = 0;
            int n1 = 1;
            int n2;
            for (int i=0;i<count;i++)
            {
                n2 = n + n1;
                n = n1;
                n1 = n2;
                Console.WriteLine(n2);
            }
            Console.ReadKey();
        }
    }
}
