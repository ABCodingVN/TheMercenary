using System;
using System.Collections.Generic;
using BackendTiki.Models;
using BackendTiki.Dto;
using System.Data;

namespace BackendTiki.Interface
{
    public interface IProductRepository : IDisposable
    {
        DataTable GetProducts();
        List<Product> GetProductsLinq();
        List<Product> GetProductsByCategoryID(string category);
        List<Product> GetLazyProducts(int pageNum, int pageSize);
        Product GetProductByID(string ProductId);
        void InsertProduct(Product Product);

        List<Product> GetBySearch(SearchProducts search);
        Object GetDetailProductByID(string ProductId);
        void Save();
    }
}
