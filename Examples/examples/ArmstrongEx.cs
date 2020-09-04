using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.examples
{
    class ArmstrongEx
    {
        public static void MainMethod(string[] arg)
        {

            int n = 153;
            int sum = 0;
            int r;
            int temp;
            temp = n;

            while(n>0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }

            if (temp == sum)
                Console.WriteLine("Is Armstrong");
            else
                Console.WriteLine("Is not Armstrong");

            Console.ReadKey();
        }
    }
}
