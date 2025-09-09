using System.ComponentModel.DataAnnotations;

namespace Toy_Store.Models
{
    public class Products
    {
            [Key]
            public required int ProductId { get; set; }
            public int CategoryID { get; set; }
            public required string ProductName { get; set; }
            public required string Description { get; set; }
            public decimal Price { get; set; }
            public int Stock { get; set; }
            public  required string ImageUrl { get; set; }

        // Navigation property
        public required Category Category { get; set; }
            public  required ICollection<OrderDetails> OrderDetails { get; set; }
            public required ICollection<Cart> Carts { get; set; }
        }


}
