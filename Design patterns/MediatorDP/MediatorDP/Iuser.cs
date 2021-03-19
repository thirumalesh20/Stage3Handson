using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    public interface IUser
    {
        string Name { get; set; }
        void RecieveMesage(IUser u, string msg);
        void SendMesage(string msg);
    }
}
