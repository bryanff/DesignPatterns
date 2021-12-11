using DesignPatterns.Adapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Persistance
{
    public class UserMySQLDBPersistance
    {
        public void save(User user)
        {
            Console.WriteLine("Saving user data in Mysql");
        }
    }
}
