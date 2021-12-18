using System;

namespace ITHS_CC_Labb2
{
    public interface IMessageSender
    {
        public string SendMessage(string email, Guid ID);
    }
}