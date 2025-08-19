using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductType { get; set; }
        public int Quantity { get; set; }
        public DateTime ProducedAt { get; set; }

        public int AnimalId { get; set; }
        public virtual Animal Animal { get; set; }

        public List<Sale> Sales { get; set; }
    }
}
