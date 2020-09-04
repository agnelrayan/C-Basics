using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.examples
{
    class PalindromeEx
    {
        public static void MainMethod(string[] arg)
        {

            int n, r, sum=0,temp;
            n = 121;
            temp = n;

            while (n>0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;

            }

            if (temp == sum)
                Console.WriteLine("Is Palindrome");
            else
                Console.WriteLine("Is not Palindrome");

            Console.ReadKey();
        }
    }
}
