using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.events
{
    public interface IEvent
    {
        public Dictionary<string, Object> Metadata();
    }
}
