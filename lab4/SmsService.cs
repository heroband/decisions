using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4
{
    public class SmsService
    {
        private string _phone;
        private string _sender;

        public SmsService(string phone, string sender)
        {
            _phone = phone;
            _sender = sender;
        }

        public void SendMessage(string title, string message)
        {
            // Логіка відправки SMS
            Console.WriteLine($"Sent SMS with title '{title}' from '{_sender}' to '{_phone}': '{message}'.");
        }
    }
}