using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Examples.regexample
{
    class TestOne
    {
        public static void MainMethod(string[] args)
        {
            //Console.WriteLine("hi");

            mask();
            Console.ReadKey();

        }

        public static void mask()
        {
            //string cardNumber = "548110******8801";

            string cardNumber = "548110******8801";

            string firstDigits = cardNumber.Substring(0, 6);
            string lastDigits = cardNumber.Substring(cardNumber.Length - 4, 4);

            string requiredMask = new String('*', cardNumber.Length - firstDigits.Length - lastDigits.Length);

            string maskedString = string.Concat(firstDigits, requiredMask, lastDigits);
            string maskedCardNumberWithSpaces = Regex.Replace(maskedString, ".{4}", "$0");

            Console.WriteLine(maskedCardNumberWithSpaces);
        }
    }
}
