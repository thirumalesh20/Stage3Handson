using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorDP
{
    public interface MovableAdapter
    {
        //return speed in KM/H

        double getSpeed();
        //return price in euro

        double GetPrice();
    }
}
