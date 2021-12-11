using DesignPatterns.Adapter.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class UserDataPersistance //Client
    {
        private readonly ProfileDynamoDBAdapter dynamoDBAdapter;
        private readonly UserMysqlAdapter mysqlAdapter;
        public UserDataPersistance(ProfileDynamoDBAdapter adapter1, UserMysqlAdapter adapter2)
        {
            this.dynamoDBAdapter = adapter1;
            this.mysqlAdapter = adapter2;
        }
        public void save(UserDto user)
        {
            this.dynamoDBAdapter.save(user);
            this.mysqlAdapter.save(user);
        }
    }
}
