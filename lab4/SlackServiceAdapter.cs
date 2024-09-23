using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4
{
    public class SlackServiceAdapter : INotification
    {
        private SlackService _slackService;
        public SlackServiceAdapter(SlackService slackService)
        {
            _slackService = slackService;
        }
        public void Send(string title, string message)
        {
            _slackService.SendMessage(title, message);
        }
    }
}