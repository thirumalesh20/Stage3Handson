using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadLight;
using Tire;

namespace Factory
{
    public abstract class Afactory
    {
        public abstract AHeadLight makeHeadlight();
        public abstract ATire makeTire();
        public static Afactory GetFactory(string type)
        {
            if (type.Equals("Audi"))
            {
                return new AudiFactory();
            }
            else
            {
                return new MercedesFactory();
            }
        }
    }
}
