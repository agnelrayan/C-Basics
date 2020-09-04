using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.examples
{
    class ReverseEx
    {
        public static void MainMethod(string[] arg)
        {
            string str = "welcome";
            char[] ch = str.ToCharArray();

            for (int i=ch.Length-1;i>=0;i--)
            {

                Console.WriteLine(ch[i]);
            }

            Console.ReadKey();
        }
    }
}
