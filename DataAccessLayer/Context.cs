using System.Data.Entity;
using EntityLayer.Entities;

namespace DataAccessLayer
{
    public class Context: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
