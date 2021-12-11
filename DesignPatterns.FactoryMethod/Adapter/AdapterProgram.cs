using DesignPatterns.Adapter.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{

    public class AdapterProgram
    {
        public static void Run()
        {
            ProfileDynamoDBAdapter adapter1 = new ProfileDynamoDBAdapter(
                new Persistance.ProfileDynamoDBPersistance());
            UserMysqlAdapter adapter2 = new UserMysqlAdapter(
                new Persistance.UserMySQLDBPersistance());
            UserDataPersistance persistance = new UserDataPersistance(adapter1, adapter2);
            UserDto user = new UserDto();
            user.name = "Juanito Perez";
            user.email = "juanito@gmail.com";
            user.password = "$5412svF";
            user.FacebookID = "112121549745";
            user.GoogleID = "10002558945";
            persistance.save(user);
        }
    }










}
