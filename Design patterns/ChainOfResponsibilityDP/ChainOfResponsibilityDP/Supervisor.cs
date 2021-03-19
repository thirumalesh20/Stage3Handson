using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDP
{
    class SuperVisor : ILeaveRequestHandler
    {
        private ILeaveRequestHandler nextHandler;

        public ILeaveRequestHandler NextHandler { get => nextHandler; set => nextHandler = value; }

        public void HandleRequest(LeaveRequest Lr)
        {
            if (Lr.LeaveDays < 3)
                Console.WriteLine("Leave approved by SuperVisor");
            else
            {
                Console.WriteLine("Leave request rejected by Supervisor and  passed to ProjectManager\n");

                NextHandler = new ProjectManager();
                NextHandler.HandleRequest(Lr);

            }
        }


    }
}
