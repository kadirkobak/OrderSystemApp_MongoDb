using MongoDB.Bson;
using OrderSystemApp_MongoDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemApp_MongoDb.Services
{
    public class OrderOperation
    {
        public void AddOrder(Order order)
        {
            var connection = new MongoDbConnection();
            var orderCollection = connection.GetOrdersCollection();

            var document = new BsonDocument
            {
                
                { "CustomerName", order.CustomerName },
                { "District", order.District },
                { "City", order.City },
                { "TotalPrice", order.TotalPrice }
            };

            orderCollection.InsertOne(document);
        }
    }
}
