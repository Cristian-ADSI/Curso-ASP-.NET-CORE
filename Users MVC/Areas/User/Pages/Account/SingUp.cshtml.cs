using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Users_MVC.Areas.User.Pages.Account
{
    public class SingUpModel : PageModel
    {

        public void OnGet()
        {
        }

        [BindProperty]
        public ImputModel Imput { get; set; }
        public class ImputModel{
            [Required]
            [EmailAddress]
            [Display (Name = "Email")]
            public string Email { get; set; }

            [Required]
            [Display (Name = "Key")]
            [DataType(DataType.Password)]
            [StringLength(100, ErrorMessage = " The number of characters of {0} must be almost {2}.", MinimumLength = 8)] 
            public string Password { get; set; }


            [Required]
            [Display(Name = "Confirm Key")]
            [DataType(DataType.Password)]
            [Compare("Password", ErrorMessage ="The password & conrfim password don`t match, please verify it")]
            public string Confirmassword { get; set; }

        }
    }
}
