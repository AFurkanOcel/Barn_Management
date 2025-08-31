using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        public int UserID { get; set; }
        public virtual User User { get; set; }

        public decimal Balance { get; set; }
        public string Operation { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
