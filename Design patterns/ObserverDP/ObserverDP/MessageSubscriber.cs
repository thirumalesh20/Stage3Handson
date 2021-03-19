using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    public class MessageSubscriber : Observer
    {
        public void Update(Message msg)
        {

            Console.WriteLine("MessageSubscriber :: " + msg.getMessageContent());

        }

    }


    public class MessageSubscriberTwo : Observer

    {



        public void Update(Message msg)
        {

            Console.WriteLine("MessageSubscriberTwo :: " + msg.getMessageContent());

        }

    }


    public class MessageSubscriberThree : Observer

    {



        public void Update(Message msg)
        {

            Console.WriteLine("MessageSubscriberThree :: " + msg.getMessageContent());

        }

    }
}
