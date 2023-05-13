using EasyShop.Model;
using Microsoft.EntityFrameworkCore;

namespace EasyShop.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<BillingInfo> BillingInfo { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<PersonalInfo> PersonalInfo { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Subcategory> Subcategory { get; set; }
    }
}
