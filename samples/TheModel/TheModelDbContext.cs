using System.Data.Entity;

namespace TheModel
{
    public class TheModelDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }

    public class TheModelDbContextInitializer : DropCreateDatabaseAlways<TheModelDbContext>
    {
        protected override void Seed(TheModelDbContext context)
        {
            context.Customers.AddRange(Customer.GetSampleGenericList());
            context.Orders.AddRange(Order.GetSampleGenericList());
            context.Products.AddRange(Product.GetSampleGenericList());

            base.Seed(context);
        }
    }
}