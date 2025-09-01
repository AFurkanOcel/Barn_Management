using System.Collections.Generic;
using DataAccessLayer;
using EntityLayer.Entities;

namespace BusinessLayer
{
    public class TransactionManager
    {
        Repository<Transaction> TransactionRepo = new Repository<Transaction>();

        public List<Transaction> GetAll()
        {
            return TransactionRepo.GetAll();
        }
        public int Insert(Transaction t)
        {
            return TransactionRepo.Insert(t);
        }
    }
}
