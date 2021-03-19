using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDP
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeMaker sm = new ShapeMaker();

            sm.DrawCircle();
            sm.DrawRectangle();
            sm.DrawSquare();

            Console.WriteLine("The required shapes are created");
            Console.ReadKey();
        }
    }
}
