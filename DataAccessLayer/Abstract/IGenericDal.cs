using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        int Insert(T p);
        int Delete(T p);
        int Update(T p);
        List<T> GetAll();
        T GetById(int id);
    }
}
