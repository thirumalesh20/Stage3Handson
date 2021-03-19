using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    public interface Subject
    {
        int GetState { get; set; }

        void ChangeState(int val);
        void Attach(Observer obs);

        void Detach(Observer obs);
    }
}
