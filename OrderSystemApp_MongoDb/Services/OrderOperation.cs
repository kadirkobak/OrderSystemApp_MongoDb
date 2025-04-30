using MongoDB.Bson;
using MongoDB.Driver;
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

        public List<Order> GetAllOrders()
        {
            var connection = new MongoDbConnection();
            var orderCollection = connection.GetOrdersCollection();

            var orders = orderCollection.Find(new BsonDocument()).ToList();

            List<Order> orderList = new List<Order>();

            foreach (var order in orders)
            {
                orderList.Add(new Order
                {
                    OrderId = order["_id"].ToString(),
                    CustomerName = order["CustomerName"].ToString(),
                    District = order["District"].ToString(),
                    City = order["City"].ToString(),
                    TotalPrice = order["TotalPrice"].ToDecimal()
                });
            }

            return orderList;
        }


        public void DeleteOrder(string orderId)
        {
            var connection = new MongoDbConnection();
            var orderCollection = connection.GetOrdersCollection();
            
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(orderId));
            orderCollection.DeleteOne(filter);
        }
    }
}
