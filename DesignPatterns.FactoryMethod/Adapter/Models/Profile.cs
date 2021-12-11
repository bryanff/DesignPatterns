using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Models
{
    public class Profile
    {
        private string FacebookID;
        private string GoogleID;
        public Profile(string facebookID, string googleID = null)
        {
            FacebookID = facebookID;
            GoogleID = googleID;
        }
    }
}
