using Microsoft.AspNetCore.Mvc;

namespace Users_MVC.Controllers
{
    public class UsersController : Controller
    {
        //[HttpGet]
        public IActionResult Index(string name, int age)
        {
            string Data = name+" "+age;
            return View("Index", Data);
        }
    }
}
