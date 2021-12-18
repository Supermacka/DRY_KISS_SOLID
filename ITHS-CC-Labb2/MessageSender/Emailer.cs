using System;

namespace ITHS_CC_Labb2
{
    public class Emailer : IMessageSender
    {
        public string SendMessage(string email, Guid ID)
        {
            // Some email sending logic we don't care about
            return $"Notification sent to email {email} for order {ID}";
        }
    }
}