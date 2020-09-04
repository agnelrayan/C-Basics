using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.samples
{
    class StringArrayEx
    {
        public static void MainMethod(string[] args)
        {
            String[] str = new String[3];
            //String[] str_arr = new String[3];

            str[0] = "Joe";
            str[1] = "Joy";
            str[2] = "Jose";

            for (int i=0;i<str.Length;i++)
            {
                Console.WriteLine("value at index position: "+i+ " is: "+ str[i]);
            }

            Console.ReadKey();
        }
    }
}
