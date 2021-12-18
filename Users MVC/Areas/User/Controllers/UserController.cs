using Microsoft.AspNetCore.Mvc;

namespace Users_MVC.Areas.User.Controllers
{
    public class UserController : Controller
    {   
        [Area("User")]
        public IActionResult User()
        {
            return View();
        } 
    }
}
