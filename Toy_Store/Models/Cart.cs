using System.ComponentModel.DataAnnotations;

namespace Toy_Store.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        // Navigation
        public required User User { get; set; }
        public required Products Product { get; set; }
    }
}
