using Application.Command.Interfaces;
using Domain.Models;

namespace Application.Query.Implementation
{
    public class GetProduct : IGetProduct
    {
        public Product Handle(string value)
        {
            throw new System.NotImplementedException();
        }
    }
}
