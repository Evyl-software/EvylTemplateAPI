using Application.ProductServices.Interfaces;
using Domain.Models;
using MongoDB.Bson;
using System.Threading.Tasks;

namespace Application.ProductServices.Implementation
{
    public class ProductService : IProductService
    {
        public async Task<Product> CreateAsync(Product product)
        {
            return await Task.FromResult(product);
        }

        public async Task<bool> DeleteAsync(ObjectId id)
        {
            return await Task.FromResult(true);
        }

        public async Task<Product> GetAsync(ObjectId id)
        {
            return await Task.FromResult(new Product());
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            return await Task.FromResult(product);
        }
    }
}
