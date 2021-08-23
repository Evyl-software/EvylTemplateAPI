using Domain.Models;

namespace Application.ProductServices.Interfaces
{
    public interface IGetProduct
    {
        public Product Handle(string value);
    }
}
