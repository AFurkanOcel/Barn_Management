using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [StringLength(40)]
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
