using System;
using System.Collections.Generic;
using BackendTiki.Models;

namespace BackendTiki.Interface
{
    public interface ICategoryRepository : IDisposable
    {
        List<Category> GetCategorys();
        Category GetCategoryByID(string CategoryId);
        void InsertCategory(Category Category);

        void Save();
    }
}
