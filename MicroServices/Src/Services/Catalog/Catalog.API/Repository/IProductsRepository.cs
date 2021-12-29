using Catalog.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Repository
{
    public interface IProductsRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProductById(string id);
        Task<IEnumerable<Product>> GetProductsByCategory(string category);
        Task<IEnumerable<Product>>  GetProductsByName(string name);
        Task AddProduct(Product product);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProdduct(string id);
    }
}
