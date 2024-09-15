using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2
{
    public class Facebook : ISocialNetwork
    {
        private string Login { get; set; }
        private string Password { get; set; }
        public Facebook(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public void LogIn()
        {
            Console.WriteLine($"Logging in to Facebook with login: {Login}");
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"Publishing message to Facebook: {message}");
        }
    }
}