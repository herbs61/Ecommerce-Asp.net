﻿using EcommerceWithAngularWeb.Models;

namespace EcommerceWithAngularWeb.Services.Infrastuctures
{
    public interface IProduct
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
        void Insert(Product product);
        void Update(Product product);
        void Delete(int id);
        int Count();
        void Save();
    }
}
