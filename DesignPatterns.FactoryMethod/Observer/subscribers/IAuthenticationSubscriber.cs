using DesignPatterns.Observer.events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.subscribers
{
    public interface IAuthenticationSubscriber
    {
        public void execute(IEvent @event);
    }
}
