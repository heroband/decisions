using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2
{
    public class LinkedIn : ISocialNetwork
    {
        private string Email { get; set; }
        private string Password { get; set; }

        public LinkedIn(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public void LogIn()
        {
            Console.WriteLine($"Logging in to LinkedIn with email: {Email}");
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"Publishing message to LinkedIn: {message}");
        }
    }
}