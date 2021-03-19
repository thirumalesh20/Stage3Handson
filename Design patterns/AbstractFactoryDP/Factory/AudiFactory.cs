using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadLight;
using Tire;

namespace Factory
{
    class AudiFactory : Afactory
    {
        public override AHeadLight makeHeadlight()
        {
            return new AudiHeadLight();
        }

        public override ATire makeTire()
        {
            return new AudiTire();
        }
    }
}
