using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.EntityFramework
{
    public class EfBarnDal : GenericRepository<EntityLayer.Concrete.Barn>, Abstract.IBarnDal
    {
    }
}
