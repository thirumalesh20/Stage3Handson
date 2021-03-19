using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            Builder child = new ConcreteChildPackage();
            Builder adult = new ConcreteAdultPackage();

            director.Construct(child);
            director.Construct(adult);

            Product p1 = adult.GetResults();
            Product p2 = child.GetResults();
            //Adult Package
            Console.WriteLine("Adult Package");
            p1.Show();

            Console.WriteLine("\nChild Package");
            p2.Show();

            Console.ReadLine();
        }
    }
}
