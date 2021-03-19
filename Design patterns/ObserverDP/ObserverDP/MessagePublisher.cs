using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    public class MessagePublisher : Subject
    {
        private List<Observer> observers = new List<Observer>();

        private int getState = 1;
        public int GetState { get => getState; set => value = getState; }

        public void Attach(Observer obs)
        {

            observers.Add(obs);

        }

        public void ChangeState(int val)
        {
            if (val != getState)
            {

                GetState = val;

                NotifyUpdate(new Message("Subject State changed"));
            }
        }

        public void Detach(Observer obs)
        {
            observers.Remove(obs);
        }
        public void NotifyUpdate(Message msg)
        {


            observers.ForEach(x => x.Update(msg));
        }
    }
}
