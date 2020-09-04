using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.samples
{
    class StringInterpolationEx
    {
        public static void MainMethod(string[] args)
        {
            string name = "Mark";
            var date = DateTime.Now;

            //composite formatting
            //Console.WriteLine("Helo: {0}, Today is: {1}, It is time {2:HH:mm}", name, date.DayOfWeek, date);
            //string interpolation
            // Console.WriteLine($"Helo: {name}, Today is:{date.DayOfWeek}, Date is: {date:HH:mm}");

            //Console.WriteLine($"is your name '\' fdfd '\' {name}");

            //Console.WriteLine($"|{"Left",-7}|{"Right",7}|");

            string author = "Agnel Rayan";
            string book = "Programming C#";
            int year = 2018;
            decimal price = 45.95m;

            //string helo = $"Helo {author}";
            string helo = $"{author} is an author of {book} \n" +
                $"the book price is ${price} and was published in year {year}";
            Console.WriteLine(helo);

            Console.ReadKey();
        }
    }
}
