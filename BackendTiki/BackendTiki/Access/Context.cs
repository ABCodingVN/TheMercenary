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
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Ratting> Rattings { get; set; }
        public DbSet<ReplyRatting> ReplyRattings { get; set; }
        public DbSet<Wards> Wards { get; set; }
        public DbSet<District> District { get; set; }

        public DbSet<Province> Province { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("Categories")
                    .HasKey(e => e.CategoryId);

                entity.HasIndex(e => e.Name)
                    .IsUnique();
                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsRequired()
                    .IsUnicode(false);
                /*   entity.HasMany(p => p.Products)
                  .WithOne(d => d.Category)
                  .HasForeignKey(d => d.ProductId);*/

            });
            modelBuilder.Entity<Ratting>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("Ratting");
             /* .HasKey(e => e.RatingId);*/
                entity.Ignore(e => e.RatingId);
            });
            modelBuilder.Entity<District>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("District");
              /*.HasKey(e => e.ProvinceId);*/
                entity.Ignore(e => e.DistrictId);
            });
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("Orders");
                /*  .HasKey(e => e.OrderId);*/
                entity.Ignore(e => e.OrderId);

            });
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("Products");
              /*      .HasKey(e => e.ProductId);*/
               /* entity.Ignore(e => e.ProductId);*/

            });
            modelBuilder.Entity<Province>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("Province");
                /* .HasKey(e => e.ProvinceId);*/
                entity.Ignore(e => e.ProvinceId);
            });
            modelBuilder.Entity<ReplyRatting>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("ReplyRatting");
         /*     .HasKey(e => e.ReplyId);*/
                entity.Ignore(e => e.ReplyId);
            });
            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("Supplier");
           /* .HasKey(e => e.SupplierId);*/
                entity.Ignore(e => e.SupplierId);
            });
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("Users");
   /*         .HasKey(e => e.UserId);*/
                entity.Ignore(e => e.UserId);
            });
            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("Vouchers");
       /*     .HasKey(e => e.VoucherId);*/
                entity.Ignore(e => e.VoucherId);
            });
            modelBuilder.Entity<Wards>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("Wards");
         /*   .HasKey(e => e.WardsId);*/
                entity.Ignore(e => e.WardsId);
            });

        }
    }
}
