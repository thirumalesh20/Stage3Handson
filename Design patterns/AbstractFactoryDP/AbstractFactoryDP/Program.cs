using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory;
using Tire;
using HeadLight;

namespace AbstractFactoryDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Afactory audi = Afactory.GetFactory("Audi");
            audi.makeHeadlight();
            audi.makeTire();

            Afactory mercedes = Afactory.GetFactory("Mercedes");
            mercedes.makeHeadlight();
            mercedes.makeTire();

            Console.ReadLine();
        }
    }
}
