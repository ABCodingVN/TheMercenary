using BackendTiki.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendTiki.Access
{
    public class Context : DbContext
    {

        public Context()
        {

        }
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }

}
