using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorApi.Helpers
{
    public class MongoDBManager
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MongoConnection"].ConnectionString;
        public IMongoDatabase Db { get; set; }

        public MongoDBManager()
        {
            MongoClient client = new MongoClient(connectionString);
            Db = client.GetDatabase("sensor");
        }
    }
}
