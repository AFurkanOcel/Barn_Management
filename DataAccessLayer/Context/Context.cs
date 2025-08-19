using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Context
{
    public class Context : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Barn> Barns { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<User> Users { get; set; }
    }
}