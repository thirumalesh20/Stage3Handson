using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatMediator chat = new ChatMediator();
            IUser User1 = new PrimeUser() 
            {
                Name = "Kasim" 
            };
            IUser User2 = new BasicUser()
            { 
                Name = "Thirumalesh" 
            };
            IUser User3 = new PrimeUser() 
            {
                Name = "Vamsi" 
            };
            chat.AddUser(User1);
            chat.AddUser(User2);
            chat.AddUser(User3);

            chat.Rec(User2, "'Hello'");

            chat.SendMessage(User3, "'Hello'" );
            chat.SendMessage(User1, "'Hello'" );
            Console.ReadLine();
        }
    }
}
