using Application.ProductServices.Interfaces;
using Domain.Models;
using MongoDB.Bson;
using Repository;
using System.Threading.Tasks;

namespace Application.ProductServices.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IMongoRepository<Product> _productRepository;

        public ProductService(IMongoRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }
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
            return await _productRepository.FindOneAsync(p => p.Id == id);
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            return await Task.FromResult(product);
        }
    }
}
