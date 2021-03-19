using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorDP
{
    public interface Movable
    {
        //return speed in MPH
        double getSpeed();

        //return price in usd
        double getPrice();
    }
}
