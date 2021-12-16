using DesignPatterns.Observer.services;
using DesignPatterns.Observer.subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.events
{
    public class PinterestProfileGetter : IAuthenticationSubscriber
    {
        private readonly Pinterest _pinterest;
        public PinterestProfileGetter(Pinterest pinterest) => _pinterest = pinterest;
        public void execute(IEvent @event)
        {
            User user = (User)@event.Metadata()["user_data"];
            _pinterest.getProfile(user.PinteresID);
        }
    }
}
