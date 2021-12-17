using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsability.SanitizationHandler
{
    public abstract class SanitizationHandler : ISanitizationHandler
    {
        private ISanitizationHandler _next;
        public ISanitizationHandler setNext(ISanitizationHandler handler)
        {
            this._next = handler;
            return handler;
        }
        public abstract Request sanitize(Request request);
        protected Request follow(Request request)
        {
            return _next == null ? request : _next.sanitize(request);
        }
    }
}
