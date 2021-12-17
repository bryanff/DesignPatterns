using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsability.SanitizationHandler
{
    public class DateSanitizationHandler : SanitizationHandler
    {
        public override Request sanitize(Request request)
        {
            if (request.body.ContainsKey("date"))
            {
                DateTime DateValue;
                var formats = new[] { "yyyy-MM-dd" };
                string date = request.body["date"];
                if (!DateTime.TryParseExact(date, formats, null, DateTimeStyles.None, out DateValue))
                    request.body["date"] = "1991-01-01";
            }
            return base.follow(request);
        }
    }
}
