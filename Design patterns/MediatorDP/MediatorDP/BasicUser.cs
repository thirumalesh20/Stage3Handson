using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    public class BasicUser : IUser
    {

        public string Name { get; set; }


        ChatMediator chatMed = new ChatMediator();



        public void RecieveMesage(IUser u, string message)
        {

            Console.WriteLine(message + " sent by " + u.Name);
        }

        public void SendMesage(string message)
        {
            chatMed.SendMessage(this, message);
        }
    }
}
