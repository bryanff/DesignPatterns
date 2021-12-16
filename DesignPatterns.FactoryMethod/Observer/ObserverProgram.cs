using DesignPatterns.Observer.events;
using DesignPatterns.Observer.services;
using DesignPatterns.Observer.subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    class ObserverProgram
    {
        public static void Run()
        {

            List<string> @eventsToRegister = new List<string>()
            {
                "user.registered",
                "user.login"
            };
            IEventManager<IAuthenticationSubscriber> @event = new AuthEventManager(eventsToRegister);
            IAuthenticationSubscriber subscriber1 = new WebMasterRegistrationEmailNotifier(new EmailService());
            IAuthenticationSubscriber subscriber2 = new SMSGreetingsRegistrationNotifier(new SMSService());
            IAuthenticationSubscriber subscriber3 = new PinterestProfileGetter(new Pinterest());

            @event.subscribe("user.registered", subscriber1);
            @event.subscribe("user.registered", subscriber2);
            @event.subscribe("user.registered", subscriber3);

            AuthenticationService auth = new AuthenticationService(@event);
            auth.SignUp(new User("bryan@assuresoft.com", "115555", "+591 76147236"));
        }
    }
   
}

   
    
