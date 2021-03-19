using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDP
{
    class ShapeMaker
    {
        public Shape circle;
        public Shape rectangle;
        public Shape square;


        public void DrawCircle()
        {
            circle = new Circle();
            circle.Draw();
        }
        public void DrawRectangle()
        {
            rectangle = new Rectangle();
            rectangle.Draw();
        }

        public void DrawSquare()
        {
            square = new Square();
            square.Draw();
        }

    }
}
