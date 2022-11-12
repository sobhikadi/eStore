using LogicLayerEntities.Users;
using LogicLayerHandlers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace eStore.Pages
{
    public class SignUpModel : PageModel
    {
        UserHandler userHandler = new UserHandler();

        [BindProperty]
        [Required(ErrorMessage ="The property {0} cannot be empty")]
        [StringLength(maximumLength: 50, MinimumLength = 3,
        ErrorMessage = "The property {0} should have {1} maximum characters and {2} minimum characters")]
        public string FirstName {get; set;}
        [BindProperty]
        [Required(ErrorMessage = "The property {0} cannot be empty")]
        [StringLength(maximumLength: 50, MinimumLength = 3,
        ErrorMessage = "The property {0} should have {1} maximum characters and {2} minimum characters")]
        public string LastName { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "The property {0} cannot be empty")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "The property {0} cannot be empty")]
        public string Password { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "The property {0} cannot be empty")]
        [Compare("Password", ErrorMessage = "The fields Password and PasswordConfirmation does not match")]
        public string RepeatPassword { get; set; }



        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            Customer customer = new Customer(FirstName, LastName, Email, Password, null, null, null, null, null, null);
            userHandler.AddCustomer(customer);
            ViewData["message"] = $"Hello {FirstName} {LastName}, Welcome to eStore. Thank you for registering, please log in to view your personal data";

            return new RedirectToPageResult("LogIn", new { successMessage = ViewData["message"] });
        }
    }
}
