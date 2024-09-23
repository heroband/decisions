using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4
{
    public class SlackService
    {
        private string _login;
        private string _apiKey;
        private string _chatId;

        public SlackService(string login, string apiKey, string chatId)
        {
            _login = login;
            _apiKey = apiKey;
            _chatId = chatId;
        }

        public void SendMessage(string title, string message)
        {
            // Логіка авторизації та відправки повідомлення у Slack
            Console.WriteLine($"Sent Slack message with title '{title}' to chat '{_chatId}': '{message}'.");
        }
    }
}