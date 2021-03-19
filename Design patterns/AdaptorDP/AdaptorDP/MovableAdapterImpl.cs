using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorDP
{
    public class MovableAdapterImpl : MovableAdapter
    {
        private Movable luxuryCars;

        public MovableAdapterImpl(Movable car)
        {
            luxuryCars = car;
        }

        public double GetPrice()
        {
            return ConvertUsdToEuro(luxuryCars.getPrice());
        }

        private double ConvertUsdToEuro(double usd)
        {
            //returns euro
            return usd * 1.19;
        }
        public double getSpeed()
        {
            return ConvertMphToKm(luxuryCars.getSpeed());
        }

        private double ConvertMphToKm(double mph)
        {
            return mph * 1.60934;
        }
    }
}
