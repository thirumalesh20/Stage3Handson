using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDP
{
    public class ProjectManager : ILeaveRequestHandler
    {
        private ILeaveRequestHandler nextHandler;

        public ILeaveRequestHandler NextHandler { get { return nextHandler; } set { nextHandler = value; } }

        public void HandleRequest(LeaveRequest Lr)
        {
            if (Lr.LeaveDays < 7)
            {
                Console.WriteLine("Leave approved by ProjectManager");
            }
            else
            {
                Console.WriteLine("Leave request rejected by ProjectManager and  passed to HR\n");
                NextHandler = new HR();
                NextHandler.HandleRequest(Lr);

            }
        }
    }
}
