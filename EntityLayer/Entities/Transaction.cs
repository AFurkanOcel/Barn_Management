using System;
using System.ComponentModel.DataAnnotations;

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
