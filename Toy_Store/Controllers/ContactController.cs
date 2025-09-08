using Microsoft.AspNetCore.Mvc;

namespace Toy_Store.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
