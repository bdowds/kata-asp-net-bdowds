using System;
using System.Collections.Generic;

namespace AspNetCoreKata.ProductRepo
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GeProduct(int id);
        int DeleteProduct(int id);
        int UpdateProduct(Product prod);
        int AddProduct(Product prod);
    }
}
