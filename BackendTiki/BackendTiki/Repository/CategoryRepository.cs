
using BackendTiki.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using BackendTiki.Models;
using BackendTiki.Interface;
using BackendTiki.Access;
namespace BackendTiki.Repository
{
    public class CategoryRepository : ICategoryRepository, IDisposable
    {
        private Context context;

        public CategoryRepository(Context context)
        {
            this.context = context;
        }

        public List<Category> GetCategorys()
        {
            return context.Categories.ToList();
        }

        public Category GetCategoryByID(string id)
        {   Category Category = context.Categories.Find(id);
            if(Category == null)
                return null;
            return Category;
        }

        public void InsertCategory(Category Category)
        {
            context.Categories.Add(Category);
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
