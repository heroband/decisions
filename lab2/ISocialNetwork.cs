using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2
{
    public interface ISocialNetwork
    {
        public void LogIn();

        public void SendMessage(string message);

    }
}