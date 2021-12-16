
using DesignPatterns.Observer.events;
using DesignPatterns.Observer.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.subscribers
{
    public class WebMasterRegistrationEmailNotifier : IAuthenticationSubscriber
    {
        private readonly EmailService _emailService;

        public WebMasterRegistrationEmailNotifier(EmailService emailService)
        {
            _emailService = emailService;
        }
        public void execute(IEvent @event)
        {
            var WebMasterEmail = "admin@assuresoft.com";
            User user = (User)@event.Metadata()["user_data"];
            _emailService.send(WebMasterEmail, $"A new User has been registered with email: {user.Email}");
        }
    }
}
