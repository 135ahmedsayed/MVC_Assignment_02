using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment_2.Controllers
{
    public class HomeController : Controller
    {
        //Get /Baseurl/home/index
        [HttpGet]
        public string Index(string name)
        {
            return $"Hello From Home(Index) Page. {name}";
        }
    }
}
