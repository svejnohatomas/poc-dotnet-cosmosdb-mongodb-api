using System.Threading.Tasks;
using System.Collections.Generic;
using poc_dotnet_cosmosdb_mongodb_api.Models;

namespace poc_dotnet_cosmosdb_mongodb_api.Services
{
    public interface IProductService
    {
        public Task<List<Product>> GetNAsync(int n);
        public Task<Product> GetBySkuAsync(string sku);
        public Task CreateAsync(Product product);
        public Task<Product> UpdateAsync(Product product);
        public Task DeleteAsync(string sku);
    }
}
