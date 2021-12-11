using DesignPatterns.Adapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Persistance
{
    public class ProfileDynamoDBPersistance
    {
        public void save(Profile profile)
        {
            Console.WriteLine("Saving user profile data in DynamoDB");
        }
    }
}
