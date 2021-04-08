using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    public interface IChatMediator
    {
        void AddUser(IUser user);
        void SendMessage(IUser user, string msg);
        
    }



    public class ChatMediator : IChatMediator
    {
        public List<IUser> users = new List<IUser>();
        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(IUser user, string msg)
        {
            foreach (var User in users)
            {
                if (User != user)
                    user.RecieveMesage(user, msg);
                    
            }
        }
    }
}
