using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.samples
{
    class Rectangle
    {
        double length;
        double width;

        public void Acceptdetails()
        {
            length = 4;
            width = 2;

        }

        public double GetArea()
        {
            return length * width;
        }

        public void display()
        {
            Console.WriteLine("Length: {0}"+length);
            Console.WriteLine("Width: {0}" + width);
            Console.WriteLine("Get Area:" + GetArea());
        }
    }

    class RectangleM {
        public static void MainMethod(string[] args)
        {
            Rectangle obj = new Rectangle();
            obj.Acceptdetails();
            obj.display();
            Console.ReadKey();
        }
    }

}
