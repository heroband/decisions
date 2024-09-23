using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4
{
    public class SmsServiceAdapter : INotification
    {
        private SmsService _smsService;
        public SmsServiceAdapter(SmsService smsService)
        {
            _smsService = smsService;
        }
        public void Send(string title, string message)
        {
            _smsService.SendMessage(title, message);
        }
    }
}