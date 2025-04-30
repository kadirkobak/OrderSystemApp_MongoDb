using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace OrderSystemApp_MongoDb.Services
{
    public class MongoDbConnection
    {
        private IMongoDatabase _database;

        public MongoDbConnection()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _database = client.GetDatabase("OrderSystemApp");
        }

        public IMongoCollection<BsonDocument> GetOrdersCollection()
        {
            return _database.GetCollection<BsonDocument>("Orders");
        }
    }
}
