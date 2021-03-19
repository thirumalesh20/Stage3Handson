using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDP
{
    public interface ILeaveRequestHandler
    {
       ILeaveRequestHandler NextHandler { get; set; }

        void HandleRequest(LeaveRequest LR);
    }


    public class LeaveRequest
    {
        public string Employee { get; set; }
        public int LeaveDays { get; set; }
    }
}
