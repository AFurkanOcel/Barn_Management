using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AnimalManager : IAnimalService
    {
        public void TDelete(Animal entity)
        {
            throw new NotImplementedException();
        }

        public List<Animal> TGetAll()
        {
            throw new NotImplementedException();
        }

        public Animal TGetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Animal entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Animal Entity)
        {
            throw new NotImplementedException();
        }
    }
}
