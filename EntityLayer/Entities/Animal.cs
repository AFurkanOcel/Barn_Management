using System.ComponentModel.DataAnnotations;

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
