using Microsoft.AspNetCore.Mvc;

namespace Users_MVC.Controllers
{
 
    public class UsersController : Controller
    {
        
        public IActionResult Index()
        {
            //var url = Url.Action("Method", "Users", new {age = 52, name =  "Jhon"});
            var url = Url.RouteUrl("Usuarios", new { age = 52, name = "Jhon" });
            return Redirect(url);
        }

        [HttpGet("[controller]/[action]", Name = "Usuarios")]
        public IActionResult Method(string name, int age)
        {   
            var data = $"name {name} age {age}";
            return View("Index", data);
        }
    }
}
