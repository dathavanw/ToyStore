using System.ComponentModel.DataAnnotations;

namespace Toy_Store.Models
{
    public class Category
    {
        [Key] 
        public int CategoryId { get; set; }
        public required string CategoryName { get; set; }

        // Navigation property
        public required ICollection<Products> Products { get; set; }
    }
}
