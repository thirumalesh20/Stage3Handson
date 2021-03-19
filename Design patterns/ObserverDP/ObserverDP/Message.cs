using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    public class Message
    {
        String messageContent;

        public Message(String msg)
        {
            this.messageContent = msg;
        }
        public String getMessageContent()
        {
            return messageContent;
        }
    }
}
