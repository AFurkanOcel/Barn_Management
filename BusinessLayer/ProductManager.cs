using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer.Entities;

namespace BusinessLayer
{
    public class ProductManager
    {
        Repository<Product> ProductRepo = new Repository<Product>();

        public List<Product> GetAll()
        {
            return ProductRepo.GetAll();
        }

        public int Insert(Product p)
        {
            return ProductRepo.Insert(p);
        }

        public void Update(Product p)
        {
            ProductRepo.Update(p);
        }
    }
}
