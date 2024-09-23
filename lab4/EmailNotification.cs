using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class EmailNotification : INotification
    {
        private string _adminEmail;
        public EmailNotification(string adminEmail)
        {
            _adminEmail = adminEmail;
        }

        public void Send(string title, string message)
        {
            // Логіка відправки email
            Console.WriteLine($"Sent email with title '{title}' to '{_adminEmail}': '{message}'.");
        }
    }
}