using System.ComponentModel.DataAnnotations;

namespace Toy_Store.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="Vui lòng nhập tên đăng nhập !"), StringLength(50)]
        public required string UserName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ email !")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public required string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Mật khẩu phải từ 8 đến 20 ký tự.")]
        public required string Password { get; set; }

        [Required]
        public string Role { get; set; } = "User"; // Admin hoặc User

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
