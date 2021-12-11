using Microsoft.AspNetCore.Mvc;

namespace Users_MVC.Controllers
{
    [Route("/Usuarios")]
    public class UsersController : Controller
    {
        //[HttpGet]
        [Route("/Usuarios/home")]
        [Route("/Usuarios/index/{name")]
        public IActionResult Index(string name, int age)
        {
            string Data = name+" "+age;
            return View("Index", Data);
        }
        public IActionResult Index()
        { 
            return View();
        }
    }
}
