using BackendTiki.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendTiki.Access
{
    public class Context: DbContext
    {
   
        public Context()
        {
            
        }
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
    
}
