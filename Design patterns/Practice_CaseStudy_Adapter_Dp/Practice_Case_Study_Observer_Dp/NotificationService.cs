using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CaseStudy_Observer_Dp
{
    public interface INotificationService
    {
        void AddSubscriber(INotificationObserver observer);
        void RemoveSubscriber(INotificationObserver observer);
        void NotifySubscriber();
    }
    public class NotificationService : INotificationService
    {
        List<INotificationObserver> obs = new List<INotificationObserver>();

        public void AddSubscriber(INotificationObserver observer)
        {
            obs.Add(observer);
            Console.WriteLine("A New Member named "+ observer. Name + " is added to list \n\n *** List of Subscribers ***");
            foreach (var ob in obs)
            {
                Console.WriteLine(ob.Name);
            }
        }

        public void NotifySubscriber()
        {
            Console.WriteLine("\n ***Data of the Subscribers *** \n");
            foreach (var ob in obs)
            {
                ob.OnServerDown();
            }
        }

        public void RemoveSubscriber(INotificationObserver observer)
        {

            obs.Remove(observer);
            Console.WriteLine("\n\n An Existing Member " + observer.Name + " has removed from \n\n *** List of Subscribers ***");
            foreach (var ob in obs)
            {
                Console.WriteLine(ob.Name);
            }
        }
    }
}
