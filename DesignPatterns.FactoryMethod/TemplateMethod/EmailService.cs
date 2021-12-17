using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod
{
    public class EmailService
    {
        public bool send(string email)
        {
            Console.WriteLine("Sending email...");
            return true;
        }
    }
}
