using Domain.Models;
using MongoDB.Bson;

namespace Application.OrderServices.Interfaces
{
    public interface IOrderService
    {
        public Order Create(Order order);
        public Order Get(ObjectId id);
        public bool Delete(ObjectId id);
        public Order Update(Order order);
    }
}
