using Domain.Models;
using MongoDB.Bson;
using System.Threading.Tasks;

namespace Application.ProductServices.Interfaces
{
    public interface IProductService
    {
        public Task<Product> CreateAsync(Product product);
        Task<Product> GetAsync(ObjectId id);
        public Task<bool> DeleteAsync(ObjectId id);
        public Task<Product> UpdateAsync(Product product);
    }
}
