using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class User
    {
        private string email;
        private string pinteresID ;
        private string phoneNumber;

        public User(string email, string pinteresID, string phoneNumber)
        {
            this.email = email;
            this.pinteresID = pinteresID;
            this.phoneNumber = phoneNumber;
        }
        public string Email { get => email; set => email = value; }
        public string PinteresID { get => pinteresID; set => pinteresID = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
