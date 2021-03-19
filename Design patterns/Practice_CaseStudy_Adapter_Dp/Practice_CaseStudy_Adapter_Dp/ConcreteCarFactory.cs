using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Practice_CaseStudy_Adapter_Dp.Program;

namespace Practice_CaseStudy_Adapter_Dp
{
    public class ConcreteCarFactory : CarFactory
    {


        public void MakeLuxuryCar(Location location, CarType carType)
        {
            new LuxuryCar(carType, location);
        }

        public void MakeMicroCar(Location location, CarType carType)
        {

            new MicroCar(carType, location);
        }

        public void MakeMiniCar(Location location, CarType carType)
        {

            new MiniCar(carType, location);
        }
    }
}
