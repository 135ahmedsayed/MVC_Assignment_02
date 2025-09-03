using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment_2.Controllers
{
    public class ProductsController : Controller
    {
        public string Get(int id)
        {
            return $"Welcom {id} ";
        }
    }
}
