using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab10
{
    public interface IMediator
    {
        void Notify(Component sender, string eventInfo);
    }
}