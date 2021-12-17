using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsability.SanitizationHandler
{
    public interface ISanitizationHandler
    {
        public ISanitizationHandler setNext(ISanitizationHandler handler);
        public Request sanitize(Request request);
    }
}
