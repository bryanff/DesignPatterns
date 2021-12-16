using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.services
{
    public class Pinterest 
    {
        public void getProfile(string uid) 
        {
            Console.WriteLine("getting pinteres profile - uid "+ uid);
        }
    }
}
