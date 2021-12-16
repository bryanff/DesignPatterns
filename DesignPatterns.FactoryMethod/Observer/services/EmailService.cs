using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.services
{
    public class EmailService
    {
        public void send(string email, string body)
        {
            Console.WriteLine($"Email sent to: {email} \n body: {body}");
        }
    }
}
