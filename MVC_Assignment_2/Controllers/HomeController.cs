using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment_2.Controllers
{
    public class HomeController : Controller
    {
        //Get /Baseurl/home/index
        [HttpGet]
        //public string Index(string name)
        //{
        //    return $"Hello From Home(Index) Page. {name}";
        //}

        public IActionResult Index()  //ContentResult
        {
            //var result = new ContentResult();
            //result.Content = $"Hello From Home(Index) Page for ContentResult.";
            //result.ContentType = "text/html";
            ////result.StatusCode = 200;
            ////result.StatusCode = StatusCodes.Status200OK;
            //result.StatusCode = (int)HttpStatusCode.OK;
            //return result;

            //OR
            //return Content($"Hello From Home(Index) Page for ContentResult.", "text/html");
            //_____________________//
            //View
            //View/Home/Index.cshtml
            return View();
        }
        public IActionResult update()  //RedirectResult
        {
            var result = new RedirectResult("https://www.google.com/");
            return result;
        }
        public IActionResult update2()  //RedirectToActionResult
        {
            //var result = new RedirectToActionResult(nameof(ProductsController.Get), "Products", new {id = 20});
            //return result;
            //OR
            return RedirectToAction(nameof(ProductsController.Get), "Products", new { id = 20 });
        }
    }
}
