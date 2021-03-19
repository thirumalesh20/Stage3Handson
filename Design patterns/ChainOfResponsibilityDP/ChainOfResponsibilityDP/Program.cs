using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDP
{
    class Program
    {
        static void Main(string[] args)
        {
            LeaveRequest Lr = new LeaveRequest() { LeaveDays = 2 , Employee = "Thirumalesh Jojody" };
            ILeaveRequestHandler leave = new SuperVisor();
            leave.HandleRequest(Lr);

            Console.ReadLine();
        }
    }
}
