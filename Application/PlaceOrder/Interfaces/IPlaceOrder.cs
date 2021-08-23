using Domain.Models;

namespace Application.PlaceOrder.Interfaces
{
    public interface IPlaceOrder
    {
        public Order Handle(Order order);
    }
}
