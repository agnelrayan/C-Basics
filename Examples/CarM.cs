using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class CarM
    {
        public void carM()
        {
            Car car = new Car();
            car.honk();

            Console.WriteLine(car.brand + " " + car.modelName);
            Console.ReadKey();
        }
    }
}
