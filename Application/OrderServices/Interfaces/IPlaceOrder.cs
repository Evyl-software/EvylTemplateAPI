using Domain.Models;

namespace Application.OrderServices.Interfaces
{
    public interface IPlaceOrder
    {
        public Order Handle(Order order);
    }
}
