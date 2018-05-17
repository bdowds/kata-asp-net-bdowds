using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AspNetCoreKata.ProductRepo
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        int DeleteProduct(int id);
        int UpdateProduct(Product prod);
        int AddProduct(Product prod);
    }
}
