using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.collectionex
{
    class VarEx
    {
        public static void MainMethod(string[] args)
        {
            var a = 10;
            var b = 23.23;
            var str = "hi";
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(str.GetType());

            /*The "var" keyword initializes variables with var support. 
             * The data type of a var variable will be determined when assigning values to variables.
             * The following program will automatically cast the variable*/

            Console.WriteLine("{0}\n{1}\n{2}", a, b, str);
            Console.ReadKey();
        }
    }
}