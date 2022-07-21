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

                entity.HasIndex(e => e.CategoryId)
                    .IsUnique();
                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsRequired()
                    .IsUnicode(true);
                entity.HasMany(p => p.Products)
               .WithOne(d => d.Category)
               .HasForeignKey(d => d.CategoryId)
               .OnDelete(DeleteBehavior.SetNull);

            });
            modelBuilder.Entity<Ratting>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("Ratting")
                    .HasKey(e => e.RattingId);

                entity.HasIndex(e => e.RattingId)

                    .IsUnique();

                entity.Property(e => e.ProductId)
                    .HasMaxLength(100)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                  .HasMaxLength(100)
                  .IsRequired()
                  .IsUnicode(false);

                entity.Property(e => e.PointStar)
                .IsRequired()
                .IsUnicode(false);

                entity.Property(e => e.Describe)
                 .HasMaxLength(100)
                 .IsUnicode(true);
                entity.Property(e => e.ImageURL)
                 .HasMaxLength(100)
                 .IsUnicode(false);

                entity.Property(e => e.VideoURL)
                  .HasMaxLength(100)
                  .IsUnicode(false);
                entity.Property(e => e.Time)
                 .IsUnicode(false);
                entity.Property(e => e.Likee)
                 .IsUnicode(false);
            });
            modelBuilder.Entity<District>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("District")
                    .HasKey(e => e.DistrictId);

                entity.HasIndex(e => e.DistrictId)
                    .IsUnique();

                entity.Property(e => e.ProvinceId)
                    .HasMaxLength(100)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.NameDistrict)
                    .HasMaxLength(100)
                    .IsRequired()
                     .IsUnicode(true);
                entity.HasMany(p => p.Wards)
                  .WithOne(d => d.District)
                  .HasForeignKey(d => d.DistrictId)
                  .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(p => p.Province)
                 .WithMany(d => d.Districts)
                 .HasForeignKey(d => d.DistrictId)
                 .OnDelete(DeleteBehavior.SetNull);
            });
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("Orders")
                    .HasKey(e => e.OrderId);

                entity.HasIndex(e => e.OrderId)
                    .IsUnique();

                entity.Property(e => e.ProductId)
                    .HasMaxLength(100)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .IsRequired()
                    .IsUnicode(false);
                entity.Property(e => e.VoucherId)
                 .HasMaxLength(100)
                 .IsRequired();
                entity.Property(e => e.Quantity)
                 .IsRequired();
                entity.Property(e => e.TotalPayment)
             
                 .IsRequired();
                entity.Property(e => e.DiscountMoney)

                .IsRequired();
                entity.Property(e => e.DateOrders)

               .IsRequired();


                entity.HasOne(p => p.Vouchers)
                 .WithMany(d => d.Orders)
                 .HasForeignKey(d => d.OrderId)
                 .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(p => p.Product)
                 .WithMany(d => d.Orders)
                 .HasForeignKey(d => d.OrderId)
                 .OnDelete(DeleteBehavior.SetNull);


            });
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("Products")
                    .HasKey(e => e.ProductId);

                entity.HasIndex(e => e.ProductId)
                    .IsUnique();

                entity.Property(e => e.SupplierId)
                    .HasMaxLength(100)
                    .IsRequired()
                    .IsUnicode(false);
                entity.Property(e => e.CategoryId)
                    .HasMaxLength(100)
                  .IsRequired()
                  .IsUnicode(false);

                entity.Property(e => e.RattingId)
                .HasMaxLength(100)
                 .IsRequired()
                 .IsUnicode(false);
                entity.Property(e => e.Name)
                  .HasMaxLength(100)
                  .IsRequired()
                  .IsUnicode(true);
                entity.Property(e => e.ImageURL)
                .HasMaxLength(200)
                .IsRequired()
                .IsUnicode(false);
                entity.Property(e => e.Price)
                .IsRequired()
                .IsUnicode(false);
                entity.Property(e => e.Description)
                .HasMaxLength(3000)
                .IsRequired()
                 .IsUnicode(true);
                entity.Property(e => e.Quantity)
                .IsRequired()
                .IsUnicode(false);
                entity.Property(e => e.Size)
                .HasMaxLength(100)
                .IsRequired()
                .IsUnicode(false);


                entity.Property(e => e.Color)
                .HasMaxLength(100)
                .IsRequired()
                .IsUnicode(false);

                entity.Property(e => e.Origin)
                 .HasMaxLength(100)
                 .IsUnicode(false);
                entity.Property(e => e.OriginBrand)
                 .HasMaxLength(100)
                 .IsUnicode(true);

                entity.Property(e => e.LocalBrand)
                  .HasMaxLength(100)
                   .IsUnicode(true);
                entity.Property(e => e.ExpiryDate)
                 .IsUnicode(false);

                entity.HasOne(p => p.Category)
                .WithMany(d => d.Products)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.SetNull); 

                entity.HasOne(p => p.Supplier)
                .WithMany(d => d.Products)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.SetNull); 

                entity.HasOne(p => p.Ratting)
                  .WithMany(d => d.Products)
                  .HasForeignKey(d => d.ProductId)
                  .OnDelete(DeleteBehavior.SetNull); 

                entity.HasMany(p => p.Rattings)
                  .WithOne(d => d.Product)
                  .HasForeignKey(d => d.ProductId)
                  .OnDelete(DeleteBehavior.SetNull); 

            });
            modelBuilder.Entity<Province>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("Province")
                    .HasKey(e => e.ProvinceId);

                entity.HasIndex(e => e.ProvinceId)
                    .IsUnique();

                entity.Property(e => e.NameProvince)
                    .HasMaxLength(100)
                    .IsRequired()
                   .IsUnicode(true);
                entity.HasMany(p => p.Districts)
                  .WithOne(d => d.Province)
                  .HasForeignKey(d => d.ProvinceId)
                  .OnDelete(DeleteBehavior.SetNull); ;
            });
            modelBuilder.Entity<ReplyRatting>(entity =>
            {

                entity.HasNoKey();
                entity.ToTable("ReplyRatting")
                    .HasKey(e => e.ReplyId);

                entity.HasIndex(e => e.ReplyId)
                    .IsUnique();

                entity.Property(e => e.SupplierId)
                    .IsRequired()
                    .IsUnicode(false);


                entity.Property(e => e.RattingId)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Decribe)
                  .HasMaxLength(100)
                  .IsRequired()
                 .IsUnicode(true);

                entity.Property(e => e.Time)
                .IsRequired()
                .IsUnicode(false);

                entity.Property(e => e.Likee)
              .IsRequired()
              .IsUnicode(false);

                entity.HasOne(p => p.Supplier)
               .WithMany(d => d.ReplyRatings)
               .HasForeignKey(d => d.SupplierId)
               .OnDelete(DeleteBehavior.SetNull); ;


            });
            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("Supplier")
                    .HasKey(e => e.SupplierId);

                entity.HasIndex(e => e.SupplierId)
                    .IsUnique();

                entity.Property(e => e.NameShop)
                    .HasMaxLength(100)
                    .IsRequired()
              .IsUnicode(true);

                entity.Property(e => e.QuantityFollower)
                 .IsRequired()
                 .IsUnicode(false);

                entity.Property(e => e.AddressShop)
                  .HasMaxLength(100)
                  .IsRequired()
                  .IsUnicode(true);

                entity.Property(e => e.PercentRepChat)
                .IsRequired()
                .IsUnicode(false);

                entity.HasMany(p => p.Products)
               .WithOne(d => d.Supplier)
               .HasForeignKey(d => d.SupplierId)
               .OnDelete(DeleteBehavior.SetNull);

                entity.HasMany(p => p.ReplyRatings)
              .WithOne(d => d.Supplier)
              .HasForeignKey(d => d.SupplierId)
              .OnDelete(DeleteBehavior.SetNull); ;
            });
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("Users")
                    .HasKey(e => e.UserId);

                entity.HasIndex(e => e.UserId)
                    .IsUnique();

                entity.Property(e => e.WardsID)
                    .HasMaxLength(100)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                 .IsRequired()
                 .IsUnicode(true);

                entity.Property(e => e.Password)
                  .HasMaxLength(100)
                  .IsRequired()
                  .IsUnicode(false);

                entity.Property(e => e.TypeAccount)
                .IsRequired()
                .IsUnicode(false);


                entity.Property(e => e.PhoneNumber)
                 .IsRequired()
                 .IsUnicode(false);

                entity.Property(e => e.Address)
                  .HasMaxLength(100)
                  .IsRequired()
                .IsUnicode(true);

                entity.Property(e => e.Gmail)
                .IsRequired()
                .IsUnicode(false);

           

            });
            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("Vouchers")
                    .HasKey(e => e.VoucherId);

                entity.HasIndex(e => e.CodeVoucher)
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(true);


                entity.Property(e => e.DateBegin)
                    .IsRequired()
                    .IsUnicode(false);

                    entity.Property(e => e.DateFinish)
                      .HasMaxLength(100)
                      .IsRequired()
                      .IsUnicode(false);

                    entity.Property(e => e.Quantity)
                    .IsRequired()
                    .IsUnicode(false);

                    entity.Property(e => e.QuantityUsed)
                  .IsRequired()
                  .IsUnicode(false);
                entity.Property(e => e.PercentDiscount)
                .IsRequired()
                .IsUnicode(false);
                entity.Property(e => e.MaxMoney)
                .IsRequired()
                .IsUnicode(false);
       

                entity.HasMany(p => p.Orders)
                   .WithOne(d => d.Vouchers)
                   .HasForeignKey(d => d.VoucherId)
                   .OnDelete(DeleteBehavior.SetNull);
            });
            modelBuilder.Entity<Wards>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("Wards")
                    .HasKey(e => e.WardsId);

                entity.HasIndex(e => e.WardsId)
                    .IsUnique();

                entity.Property(e => e.DistrictId)
                    .HasMaxLength(100)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.NameWards)
                    .HasMaxLength(100)
                    .IsRequired()
                   .IsUnicode(true);
             

                entity.HasOne(p => p.District)
                   .WithMany(d => d.Wards)
                   .HasForeignKey(d => d.WardsId)
                   .OnDelete(DeleteBehavior.SetNull);
            });

        }
    }
}
