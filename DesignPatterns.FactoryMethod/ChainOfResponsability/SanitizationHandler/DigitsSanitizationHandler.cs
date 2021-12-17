using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsability.SanitizationHandler
{
    public class DigitsSanitizationHandler : SanitizationHandler
    {
        public override Request sanitize(Request request)
        {
            if (request.body.ContainsKey("digits"))
            {
                string digits = request.body["digits"];
                Regex regex = new Regex("^[0-9]+$");
                if (!(regex.IsMatch(digits)))
                    request.body["digits"] = "0";
            }
            return base.follow(request);
        }
    }
}
