using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Barn
    {
        public int BarnId { get; set; }
        public int Capacity { get; set; }
        public int CurrentAnimalCount { get; set; }
        public decimal Balance { get; set; }

        public List<Animal> Animals { get; set; }
    }
}
