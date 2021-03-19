using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Movable car = new BugattiVeyron();
            MovableAdapter car2 = new MovableAdapterImpl(car);

            Console.WriteLine("Speed in MPH is " + car.getSpeed());
            Console.WriteLine("Speed in KMPH is " + car2.getSpeed());
            Console.WriteLine();
            Console.WriteLine("Price in USD is " + car.getPrice());
            Console.WriteLine("Price in Euro is " + car2.GetPrice());

            Console.ReadLine();

        }
    }
}
