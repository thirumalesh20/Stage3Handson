using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Practice_CaseStudy_Adapter_Dp.Program;

namespace Practice_CaseStudy_Adapter_Dp
{
    public interface CarFactory
    {
        void MakeMicroCar(Location location, CarType carType);
        void MakeMiniCar(Location location, CarType carType);
        void MakeLuxuryCar(Location location, CarType carType);
    }
}
