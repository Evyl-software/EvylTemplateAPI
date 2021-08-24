using Application.OrderServices.Interfaces;
using Domain.Models;
using MongoDB.Bson;

namespace Application.OrderServices.Implementation
{
    public class OrderService : IOrderService
    {
        public Order Create(Order order)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(ObjectId id)
        {
            throw new System.NotImplementedException();
        }

        public Order Get(ObjectId id)
        {
            throw new System.NotImplementedException();
        }

        public Order Update(Order order)
        {
            throw new System.NotImplementedException();
        }
    }
}
