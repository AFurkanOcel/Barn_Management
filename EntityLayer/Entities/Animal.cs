using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Animal
    {
        [Key]
        public int AnimalID { get; set; }
        public string Type { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        public int Age { get; set; }
        public bool IsAlive { get; set; }
        public int Progress { get; set; }
    }
}
