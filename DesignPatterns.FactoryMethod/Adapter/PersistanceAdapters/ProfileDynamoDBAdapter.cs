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
    public class ProfileDynamoDBAdapter : IDataPersistance
    {
        private ProfileDynamoDBPersistance persistance;

        public ProfileDynamoDBAdapter(ProfileDynamoDBPersistance persistance)
        {
            this.persistance = persistance;
        }

        public void save(UserDto user)
        {
            Profile profile = new Profile(user.FacebookID, user.GoogleID);
            this.persistance.save(profile);
        }
    }
}
