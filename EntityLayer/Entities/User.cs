using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [StringLength(40)]
        public string UserName { get; set; }

        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
