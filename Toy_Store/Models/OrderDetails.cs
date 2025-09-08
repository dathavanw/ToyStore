using System.ComponentModel.DataAnnotations;

namespace Toy_Store.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        // Navigation
        public required Orders Order { get; set; }
        public required Products Product { get; set; }
    }
}
