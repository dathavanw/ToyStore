using System.ComponentModel.DataAnnotations;

namespace Toy_Store.Models
{
    public class Orders
    {
        [Required]
        [Key]
        public int OrderId{ get; set; }
        public int UserId{ get; set; }

        [Required]
        public DateTime OrderDate{ get; set; }
        [Required]
        public decimal TotalAmount{ get; set; }

        public required string Status { get; set; }

        // Navigation
        public required User User { get; set; }
        public required ICollection<OrderDetails> OrderDetails { get; set; }

    }
}
