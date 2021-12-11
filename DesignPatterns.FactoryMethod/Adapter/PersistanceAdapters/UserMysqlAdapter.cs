using DesignPatterns.Adapter.Models;
using DesignPatterns.Adapter.Persistance;
using DesignPatterns.Adapter.PersistanceAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Adapters
{
    public class UserMysqlAdapter : IDataPersistance
    {
        private UserMySQLDBPersistance persistance;

        public UserMysqlAdapter(UserMySQLDBPersistance persistance)
        {
            this.persistance = persistance;
        }

        public void save(UserDto user)
        {
            User newuser = new User(user.name, user.email, user.password);
            this.persistance.save(newuser);
        }
    }
}
