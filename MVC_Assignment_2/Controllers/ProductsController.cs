using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment_2.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Get()
        {
            return View();
        }
    }
}
