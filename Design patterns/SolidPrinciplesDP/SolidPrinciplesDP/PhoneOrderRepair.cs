using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDP
{
    interface IOrder
    {
        void ProcessOrder(string modelName);
    }
    interface IPhoneRepair
    {
        void ProcessPhoneRepair(string modelName);

    }
    interface IAccessoryRepair
    {
        void ProcessAccessoryRepair(string accessoryType);
    }

    class Repair : IPhoneRepair, IAccessoryRepair
    {
        public void ProcessPhoneRepair(string modelName)
        {
            Console.WriteLine(string.Format("{0} repair accepted!", modelName));
        }
        public void ProcessAccessoryRepair(string accessoryType)
        {
            Console.WriteLine(string.Format("{0} repair accepted!", accessoryType));
        }

       
    }

    class PhoneOrder : IOrder
    {
        public void ProcessOrder(string modelName)
        {
            Console.WriteLine(string.Format("{0} order accepted!", modelName));
        }
    }
}
