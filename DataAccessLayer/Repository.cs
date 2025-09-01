using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataAccessLayer.Abstract;

namespace DataAccessLayer
{
    public class Repository<T>: IGenericDal<T> where T : class
    {
        Context Context = new Context();
        DbSet<T> _object;

        public Repository()
        {
            _object = Context.Set<T>();
        }

        public int Delete(T p)
        {
            _object.Remove(p);
            return Context.SaveChanges();
        }
        public List<T> GetAll()
        {
            return _object.ToList();
        }
        public T GetById(int id)
        {
            return _object.Find(id);
        }
        public int Insert(T p)
        {
            _object.Add(p);
            return Context.SaveChanges();
        }
        public int Update(T p)
        {
            return Context.SaveChanges();

        }
    }
}
