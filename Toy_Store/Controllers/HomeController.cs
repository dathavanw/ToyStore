using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection.Metadata;
using Toy_Store.Data;
using Toy_Store.Models;
using Toy_Store.ViewModels;

namespace Toy_Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DBContext _context; 

        public HomeController(ILogger<HomeController> logger, DBContext context)
        {
            _logger = logger;
            _context = context;
        }

       


        public IActionResult Index()
        {
            var bestSellers = (from od in _context.OrderDetails
                               join p in _context.Products on od.ProductID equals p.ProductId
                               group od by new {  p.ProductName , p.Price , p.ImageUrl} into g
                               orderby g.Sum(x => x.Quantity) descending
                               select new BestSellerProduct
                               {
                                   ProductName = g.Key.ProductName,
                                   Price = g.Key.Price,
                                   ImageUrl = g.Key.ImageUrl

                               }).Take(4).ToList();

            return View(bestSellers);
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
