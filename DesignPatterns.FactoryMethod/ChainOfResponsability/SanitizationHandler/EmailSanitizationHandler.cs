using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsability.SanitizationHandler
{
    public class EmailSanitizationHandler : SanitizationHandler
    {
        public override Request sanitize(Request request)
        {
            if (request.body.ContainsKey("email"))
            {
                string email = request.body["email"];
                if (!(new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").IsMatch(email)))
                {
                    Console.WriteLine("entro");
                    request.body["email"] = null;
                }
            }
            return base.follow(request);
        }
    }
}
