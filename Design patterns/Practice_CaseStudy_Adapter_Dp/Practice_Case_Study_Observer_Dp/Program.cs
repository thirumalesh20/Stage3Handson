using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CaseStudy_Observer_Dp
{
    class Program
    {
        static void Main(string[] args)
        {
            JohnObserver john = new JohnObserver();
            SteveObserver steve = new SteveObserver();

            NotificationService service = new NotificationService();
            service.AddSubscriber(steve);
            service.AddSubscriber(john);
            service.NotifySubscriber();
            service.RemoveSubscriber(steve);
            service.NotifySubscriber();

            Console.ReadLine();
        }
    }
}
