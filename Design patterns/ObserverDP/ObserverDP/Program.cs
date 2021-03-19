using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageSubscriber sub1 = new MessageSubscriber();

            MessageSubscriberTwo sub2 = new MessageSubscriberTwo();

            MessageSubscriberThree sub3 = new MessageSubscriberThree();

            MessagePublisher pub = new MessagePublisher();

            
            pub.Attach(sub1);
            pub.Attach(sub2);
            pub.Attach(sub3);

            pub.ChangeState(2);

            Console.ReadLine();
        }
    }
}
