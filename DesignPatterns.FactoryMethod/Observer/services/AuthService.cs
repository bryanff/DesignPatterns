using DesignPatterns.Observer.events;
using DesignPatterns.Observer.subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.services
{
    public class AuthenticationService
    {
        private readonly IEventManager<IAuthenticationSubscriber> _event;
        public AuthenticationService(IEventManager<IAuthenticationSubscriber> eventManager)
        {
            _event = eventManager;
        }
        public void SignUp(User user)
        {
            Console.WriteLine("Registering user...");
            _event.emit(
                "user.registered",
                new RegistrationEvent(
                    new Dictionary<string, Object> { 
                        { "user_data", user },
                        { "other","data" } 
                    }
                )
            );
        }
    }
}
