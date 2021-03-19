using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDP
{
    public class HR : ILeaveRequestHandler
    {
        private ILeaveRequestHandler Handler;
        public ILeaveRequestHandler NextHandler 
        { 
            get 
            { 
                return Handler; 
            } 
            set 
            { 
                Handler = value; 
            }
        }

        public void HandleRequest(LeaveRequest LR)
        {
            if (LR.LeaveDays < 10)
            {
                Console.WriteLine("Leaves approved by HR");
            }
            else
            {
                Console.WriteLine("Leaves rejected by HR\n");

            }
        }


    }
}
