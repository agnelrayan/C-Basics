using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.samples
{
    class SubStringEx
    {
        public static void MainMethod(string[] args)
        {
            string str = "All is well";
            Console.WriteLine(str);

            string substr=str.Substring(5);
            Console.Write(substr);
            Console.ReadKey();
        }
    }
}
