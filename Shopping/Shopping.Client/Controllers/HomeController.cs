using Microsoft.AspNetCore.Mvc;
using Shopping.Client.Models;
using Shopping.Client.Services;
using System.Diagnostics;

namespace Shopping.Client.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        private readonly IShoppingClient _shoppingClient;

        public HomeController(ILogger<HomeController> logger, IShoppingClient shoppingClient)
        {
            _logger = logger;
            _shoppingClient = shoppingClient;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _shoppingClient.GetProducts());
        }

        public IActionResult Privacy()
        {
            return View(); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
