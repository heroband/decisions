using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab10
{
    public abstract class Component
    {
        protected IMediator? _mediator;

        public void NotifyMediator(string eventInfo)
        {
            _mediator?.Notify(this, eventInfo);
        }

        public void setMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}