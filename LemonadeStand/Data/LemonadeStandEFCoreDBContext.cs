using LemonadeStand.Entities;
using Microsoft.EntityFrameworkCore;

namespace LemonadeStand.Data
{
    public class LemonadeStandEFCoreDBContext:DbContext   
    {
        public LemonadeStandEFCoreDBContext(DbContextOptions<LemonadeStandEFCoreDBContext> options):base(options)
        {

        }

        public DbSet<Order> Order { get; set; }

        public DbSet<Menu> Menu { get; set; }

        public DbSet<OrderItems> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().Property(o => o.TotalAmount).HasPrecision(22, 5);
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Order>()
            //.HasMany(p => p.OrderedItemsList)
            //.WithOne(g => g.Order).HasForeignKey(s => s.OrderID)
            //.OnDelete(DeleteBehavior.Cascade);
           
        }
    }
}
