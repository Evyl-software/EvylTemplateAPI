using Domain.Models;

namespace Application.Command.Interfaces
{
    public interface IGetProduct
    {
        public Product Handle(string value);
    }
}
