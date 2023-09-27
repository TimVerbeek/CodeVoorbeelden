using DataModels;
using Microsoft.EntityFrameworkCore;
using SharedModels;

namespace DeSpaakEntity.Data
{
    public class BroodNodigContext : DbContext
    {
        public BroodNodigContext(DbContextOptions<BroodNodigContext> options) : base(options)
        {
        }
        public DbSet<Bread> Breads { get; set; }
        public DbSet<DailySnack> DailySnacks { get; set; }
        public DbSet<InfoOrder> InfoOrders { get; set; }
		public DbSet<Topping> Toppings { get; set; }
        public DbSet<User> Users { get; set; }

    }
}

