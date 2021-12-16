using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.events
{
    public class RegistrationEvent : IEvent
    {
        private readonly Dictionary<string, Object> _metadata;

        public RegistrationEvent(Dictionary<string, object> metadata)
        {
            _metadata = metadata;
        }
        public Dictionary<string, object> Metadata() => _metadata;
    }
}
