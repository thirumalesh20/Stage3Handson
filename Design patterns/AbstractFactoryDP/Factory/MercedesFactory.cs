using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadLight;
using Tire;

namespace Factory
{
    public class MercedesFactory : Afactory
    {
        public override AHeadLight makeHeadlight()
        {
            return new MercedesHeadlight();
        }

        public override ATire makeTire()
        {
            return new MercedesTire();
        }
    }
}
