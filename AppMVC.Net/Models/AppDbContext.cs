using AppMVC.Net.Models.Blog;
using AppMVC.Net.Models.Contacts;
using AppMVC.Net.Models.Orders;
using AppMVC.Net.Models.Product;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppMVC.Net.Models
{
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
            //builder.UseSqlServer(@"Server=DESKTOP-D67BF1B\SQLEXPRESS;Database=appmvc;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasIndex(c => c.Slug).IsUnique();
            });

            // Thiết lập 2 khóa chính cho PostCategory
            modelBuilder.Entity<PostCategory>(entity =>
            {
                entity.HasKey(c => new
                {
                    c.PostID, c.CategoryID
                });
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasIndex(p => p.Slug).IsUnique();
            });





            modelBuilder.Entity<CategoryProduct>(entity =>
            {
                entity.HasIndex(c => c.Slug).IsUnique();
            });

            // Thiết lập 2 khóa chính cho PostCategory
            modelBuilder.Entity<ProductCategoryProduct>(entity =>
            {
                entity.HasKey(c => new
                {
                    c.ProductID,
                    c.CategoryID
                });
            });

            modelBuilder.Entity<ProductModel>(entity =>
            {
                entity.HasIndex(p => p.Slug).IsUnique();
            });



            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(p => p.OrderID);
                entity.HasOne(p => p.AppUser).WithMany(p => p.Orders).HasForeignKey("UserID");
            });


            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(p => new {p.OrderID, p.ProductID});
                entity.HasOne(x => x.Order).WithMany(x => x.OrderDetails).HasForeignKey(x => x.OrderID);
                entity.HasOne(x => x.Product).WithMany(x => x.OrderDetails).HasForeignKey(x => x.ProductID);
            });

        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<PostCategory> PostCategories { get; set; }




        public DbSet<CategoryProduct> CategoryProducts { get; set; }

        public DbSet<ProductModel> Products { get; set; }

        public DbSet<ProductCategoryProduct> ProductCategoryProducts { get; set; }

        public DbSet<ProductPhoto> ProductPhotos { get; set; }


        public DbSet<Order> Orders { get; set; }
    }
}
