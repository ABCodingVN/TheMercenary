
using BackendTiki.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using BackendTiki.Dto;
using BackendTiki.Interface;
using BackendTiki.Access;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore;
namespace BackendTiki.Repository
{
    public class ProductRepository : IProductRepository, IDisposable
    {
        private Context context;
        private readonly IConfiguration _configuration;
        private readonly string sqlDataSource;
        public ProductRepository(Context context, IConfiguration configuration)
        {
            this.context = context;
            _configuration = configuration;
            sqlDataSource = _configuration.GetConnectionString("sql");
        }

        public DataTable GetProducts()
        {

            string query = @"select * from Products";

            DataTable table = new DataTable();
            
            using (SqlConnection conn = new SqlConnection(sqlDataSource))
            {
                conn.Open();
                using SqlCommand cmd = new SqlCommand(query,conn);

                SqlDataReader myreader  = cmd.ExecuteReader();
                table.Load(myreader);

                myreader.Close();
                conn.Close();
            }
            return table;
        }
        public List<Product> GetProductsLinq()
        {
            context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            return context.Products.ToList();
        }

        public List<Product> GetProductsByCategoryID(string category)
        {
            List<Product> products = context.Products.Select(e=>e).Where(e => e.CategoryId == category).ToList();
            return products;
        }
        public Product GetProductByID(string id)
        {
            Product product = context.Products.SingleOrDefault(e => e.ProductId == id);
            if (product == null)
                return null;
            return product;
        }

        public void InsertProduct(Product Product)
        {
            context.Products.Add(Product);
        }
       public List<Product> GetLazyProducts(int pageNum, int pageSize)
        {
            var total = context.Products.Count();
            var skip = pageSize * (pageNum - 1);
            var canPage = skip < total;

            if (!canPage)
                return null;
            List<Product> products = context.Products.Skip(skip).Take(pageSize).ToList();
            return products;
        }
        public  Object GetDetailProductByID(string id)
        {
            try
            {

                Product product = context.Products.SingleOrDefault(e => e.ProductId == id);
                if (product != null)
                {
                    Supplier supplier = context.Suppliers.SingleOrDefault(e => e.SupplierId == product.SupplierId);
                    Ratting ratting = context.Rattings.SingleOrDefault(e => e.ProductId == product.ProductId);

                    return new
                    {
                        product,
                        supplier,
                        ratting

                    };
                }
                return null;
            }

            catch (Exception e)
            {
                return null;
            }

        }
        public List<Product> GetBySearch(SearchProducts search)
        {
            List<Product> products = context.Products.Select(e => e).Where(e => e.Name.Contains(search.InputSearch)).ToList();
            return products;
        }
   

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
