using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{

    public class UserDto
    {
        public string name { set; get; }
        public string email { set; get; }
        public string password { set; get; }
        public string FacebookID { set; get; }
        public string GoogleID { set; get; }
    }
}
