using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.samples
{
    class StringEx
    {
        public static void MainMethod(string[] args)
        {
            string fname, lname;
            fname = "Agnel";
            lname = "Rayan";

            char[] letters = { 'h','e','l','o'};
            string[] sarray = {"Ag","Joe","Raj","Josh" };

            string fullname = fname + lname;
            Console.WriteLine("FullName: {0}", fullname);

            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);

            string msg =String.Join("", sarray);
            Console.WriteLine("Message: {0}", msg);

            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);


            Console.ReadKey();

        }
    }
}
