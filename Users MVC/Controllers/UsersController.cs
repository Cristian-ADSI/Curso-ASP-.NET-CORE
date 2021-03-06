using Microsoft.AspNetCore.Mvc;

namespace Users_MVC.Controllers
{


    public class UsersController : Controller
    {

        public IActionResult Index(string name, int age)
        {
            var url = Url.RouteUrl("Usuarios", new { age = 52, name = "Jhon" });
            return Redirect(url);
        }

        [HttpGet("[controller]/[action]", Name = "Usuarios")]
        public IActionResult Method( int code)
        {
            var data = $"status code: {code}";
            return View("Index", data);
        }
    }   
}
