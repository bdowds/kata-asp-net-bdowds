﻿using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;

namespace AspNetCoreKata.ProductRepo
{
    public class ProductRepository : IProductRepository
    {
        readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public int AddProduct(Product prod)
        {
            using (var conn = _conn)
            {
                conn.Open();
                return conn.Execute("INSERT INTO product (Name) VALUES (@Name)", prod);
            }
        }

        public int DeleteProduct(int id)
        {
            using (var conn = _conn)
            {
                conn.Open();
                return conn.Execute("DELETE FROM product WHERE ProductId = @Id", new { id });
            }
        }

        public Product GeProduct(int id)
        {
            using (var conn = _conn)
            {
                conn.Open();
                return conn.Query<Product>("SELECT *, ProductId AS Id FROM product WHERE ProductId = @Id").FirstOrDefault();
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            using (var conn = _conn)
            {
                conn.Open();
                return conn.Query<Product>("SELECT *, ProductId AS Id FROM product");
            }
        }

        public int UpdateProduct(Product prod)
        {
            using (var conn = _conn)
            {
                conn.Open();
                return conn.Execute("UPDATE product SET Name = @Name WHERE ProductId = @Id", prod);
            }
        }
    }
}