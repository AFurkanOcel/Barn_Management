using System.Collections.Generic;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace DataAccessLayer
{
    public class DataAccessLayer
    {
        internal class EntityFramework
        {
            internal class EfAnimalDal : IAnimalDal
            {
                private readonly IAnimalDal _animalDal;

                public EfAnimalDal()
                {
                }

                public EfAnimalDal(IAnimalDal animalDal)
                {
                    _animalDal = animalDal;
                }

                public void Delete(Animal entity)
                {
                    _animalDal.Delete(entity);
                }

                public List<Animal> GetAll()
                {
                    return _animalDal.GetAll();
                }

                public Animal GetById(int Id)
                {
                    throw new System.NotImplementedException();
                }

                public void Insert(Animal entity)
                {
                    _animalDal.Insert(entity);
                }

                public void Update(Animal Entity)
                {
                    throw new System.NotImplementedException();
                }
            }
        }
    }
}