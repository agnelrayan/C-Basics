using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.examples
{
    class TryParseEx
    {
        public static void MainMethod(string[] args)
        {
            bool res;
            int a;
            string str = "12";
            res = int.TryParse(str,out a);
            Console.WriteLine(a);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
