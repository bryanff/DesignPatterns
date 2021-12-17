using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsability
{
    public class Request
    {
        public Dictionary<string, string> body = new();
        public Request(Dictionary<string, string> _body) => body = _body;

    }
}
