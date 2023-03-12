using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehichleUnitTesting.Vehicles;

namespace VehichleUnitTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", "Prius", 10, 50);
            Console.WriteLine(car.Make + " - " + car.Model);
        }
    }
}
