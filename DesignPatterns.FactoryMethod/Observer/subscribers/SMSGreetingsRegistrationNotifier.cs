using DesignPatterns.Observer.services;
using DesignPatterns.Observer.subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.events
{
    public class SMSGreetingsRegistrationNotifier : IAuthenticationSubscriber
    {
        private readonly SMSService _smsService;
        public SMSGreetingsRegistrationNotifier(SMSService smsService)
        {
            _smsService = smsService;
        }
        public void execute(IEvent @event)
        {
            User user = (User)@event.Metadata()["user_data"];
            _smsService.sendSMS("Greetings... Welcome to our app", user.PhoneNumber);
        }
    }
}
