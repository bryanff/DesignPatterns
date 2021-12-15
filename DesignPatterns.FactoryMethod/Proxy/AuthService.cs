using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class AuthService
    {
        public User getAuthenticated()
        {
            return new User("username", 20);
        }
    }
}
