using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.samples
{
    class EnumInSwitch
    {
        enum Level
        {
            Low,Medium,High
        }

        static void mainMethod()
        {
            Level level = Level.Medium;

            switch (level) {

                case Level.Low:
                    Console.WriteLine("Low Level");
                    break;


                case Level.Medium:
                    Console.WriteLine("Medium Level");
                    break;

                case Level.High:
                    Console.WriteLine("High Level");
                    break;

                    


            }

            Console.ReadKey();
        }
    }
}
