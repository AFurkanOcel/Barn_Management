using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer.Entities;

namespace BusinessLayer
{
    public class AnimalManager
    {
        Repository<Animal> AnimalRepo = new Repository<Animal>();

        public List<Animal> GetAll()
        {
            return AnimalRepo.GetAll();
        }

        public int Insert(Animal p)
        {
            return AnimalRepo.Insert(p);
        }

        public Animal Delete(Animal p)
        {
            AnimalRepo.Delete(p);
            return p;
        }

        public Animal GetById(int id)
        {
            return AnimalRepo.GetById(id);
        }

        public void Update(Animal p)
        {
            AnimalRepo.Update(p);
        }
    }
}
