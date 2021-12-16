using DesignPatterns.Observer.subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.events
{
    public class AuthEventManager : IEventManager<IAuthenticationSubscriber>
    {
        private readonly Dictionary<string, List<IAuthenticationSubscriber>> _subscribers = new();
        public AuthEventManager(List<string> @events)
        {
            events.ForEach((e) =>
            {
                _subscribers.Add(e, new List<IAuthenticationSubscriber>());
            });
        }
        public void subscribe(string @event, IAuthenticationSubscriber subscriber) 
        {
            List<IAuthenticationSubscriber> listSubscribers = _subscribers[@event];
            listSubscribers.Add(subscriber);
        }
        public void unsubscribe(string @event, IAuthenticationSubscriber subscriber)
        {
            List<IAuthenticationSubscriber> listSubscribers = _subscribers[@event];
            listSubscribers.Remove(subscriber);
        }
        public void emit(string @eventName, IEvent @event)
        {
            List<IAuthenticationSubscriber> subscribers = _subscribers[@eventName];
            subscribers.ForEach(
                (sub) => sub.execute(@event));
        }
    }
}
