using TaskAnswer.Models;

namespace TaskAnswer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
        public DbSet<PurchaseInvoiceProduct> PurchaseInvoiceProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(new Product[]
                {
                    new Product {Id = 1 , Name = "Tea" , Price = 10},
                    new Product {Id = 2 , Name = "Sugar" ,Price = 20},
                    new Product {Id = 3 , Name = "Salad" , Price = 30},
                });
            modelBuilder.Entity<Product>().Property(p => p.Price).HasPrecision(18, 0);
            base.OnModelCreating(modelBuilder);
        }
    }
}
