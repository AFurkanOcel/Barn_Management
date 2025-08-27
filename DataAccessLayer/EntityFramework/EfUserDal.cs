using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.EntityFramework
{
    public class EfUserDal : GenericRepository<EntityLayer.Concrete.User>, Abstract.IUserDal
    {
    }
}
