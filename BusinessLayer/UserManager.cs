using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer.Entities;

namespace BusinessLayer
{
    public class UserManager
    {
        Repository<User> UserRepo = new Repository<User>();

        public List<User> GetAll()
        {
            return UserRepo.GetAll();
        }

        public int Insert(User p)
        {
            return UserRepo.Insert(p);
        }
    }
}
