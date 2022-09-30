using LogicClassLibrary.User;
using LogicClassLibrary.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eStore.Pages
{
    public class SignUpModel : PageModel
    {
        [BindProperty]
        public Customer? Customer { get; set; }

        public void OnGet()
        {
        }
        public void OnPost() 
        {
            if (Customer != null)
            {
                UserHandler userHandler = new UserHandler();
                userHandler.AddCustomer(Customer.FirstName, Customer.LastName, Customer.Email, Customer.Password);
                ViewData["message"] = $"Hello {Customer.FirstName}, Welcome to our store";
            }
            
        }
    }
}
