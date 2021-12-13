using Microsoft.AspNetCore.Mvc;

namespace Users_MVC.Controllers
{
<<<<<<< HEAD
 
    public class UsersController : Controller
    {
        
        public IActionResult Index()
=======
    //[Route("/Usuarios")]
    public class UsersController : Controller
    {
        //[HttpGet]
        [Route("/Usuarios/home")]
        [Route("/[controller]/[action]/{name}")]
        public IActionResult Index(string name, int age)
>>>>>>> 3cebf87a9c36ba98afec61a2f3656f538b735c5d
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
