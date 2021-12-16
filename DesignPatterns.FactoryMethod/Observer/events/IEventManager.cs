using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.events
{
    public interface IEventManager<T>
    {
        public void subscribe(string @event, T subcriber);
        public void unsubscribe(string @event, T subscriber);
        public void emit(string @eventName, IEvent @event);
    }
}
