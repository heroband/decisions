using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4
{
    public interface INotification
    {
         public void Send(string title, string message);
    }
}