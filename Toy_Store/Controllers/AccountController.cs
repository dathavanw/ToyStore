using Microsoft.AspNetCore.Mvc;
using Toy_Store.Data;
using Toy_Store.Models;

namespace Toy_Store.Controllers
{
    public class AccountController : Controller
    {
        private DBContext _context;

        public AccountController(DBContext context){
            _context = context;
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            var existingUser = _context.Users.FirstOrDefault(u => u.Email ==  user.Email);
            if (existingUser != null)
            {
                ModelState.AddModelError("Email", "Email này đã được đăng ký");
                return View(user);
            }
            _context.Users.Add(user);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
           
        }


    }
}
