using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public bool IsAlive { get; set; }

        public int BarnId { get; set; }
        public virtual Barn Barn { get; set; }

        public List<Product> Product { get; set; }
    }
}
