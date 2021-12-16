using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.services
{
    public class SMSService
    {
        public void sendSMS(string message, string phone)
        {
            Console.WriteLine($"EmailService - Message: {message} - sent to: {phone}");
        }
    }
}
