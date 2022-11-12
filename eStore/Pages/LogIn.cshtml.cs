using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using LogicLayerHandlers;
using Konscious.Security.Cryptography;
using System.Text;

namespace eStore.Pages
{
    public class LogInModel : PageModel
    {
        private UserHandler userHandler = new UserHandler();

        [BindProperty]
        public string UserName { get; set; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public bool RememberMe { get; set; }



        public IActionResult OnGet(string successMessage)
        {
            ViewData["successMessage"] = successMessage;

            string role = "";

            if (Request.Cookies.ContainsKey("user"))
            {
                string[] coockieValue = Request.Cookies["user"].Split("-");

                role = coockieValue[1];
                UserName = coockieValue[0];
                HttpContext.Session.SetString("user", $"{UserName}-{role}");
            }
            else if (HttpContext.Session.GetString("user") != null) 
            {
                string[] sessionValue = HttpContext.Session.GetString("user").Split("-");
                role = sessionValue[1];
                UserName = sessionValue[0];
            }

            if (role == "Employee")
            {
                return new RedirectToPageResult("EmployeePage");
            }
            if (role == "Admin")
            {
                return new RedirectToPageResult("AdminPage");
            }
            return Page();
        }

        public IActionResult OnPost() 
        {
            if (string.IsNullOrEmpty(UserName)) return Page();
            if (string.IsNullOrEmpty(Password)) return Page();
           
            string role = userHandler.ValidateUser(UserName, Password);

            if (role != "Employee" && role != "Admin" && role != "Customer")
            {
                ViewData["LoginMessage"] = "Email or Passwrod is incorrect";
                return Page();
            }
            //set a coockie to keep logged in 
            if (RememberMe)
            {
                // set a coockie with a username
                CookieOptions cookieOptions = new CookieOptions();
                cookieOptions.Expires = DateTime.Now.AddDays(3);
                Response.Cookies.Append("user", $"{UserName}-{role}", cookieOptions);
            }
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, UserName));
            claims.Add(new Claim("id", "1"));

            if (role == "Admin")
            { claims.Add(new Claim(ClaimTypes.AuthorizationDecision, "Admin")); }

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
            HttpContext.Session.SetString("user", $"{UserName}-{role}");
            if (role == "Employee")
            {
                return new RedirectToPageResult("EmployeePage");
            }
            if (role == "Admin")
            {

                return new RedirectToPageResult("AdminPage");
            }
            if (role == "Customer")
            {

                return new RedirectToPageResult("UserPage");
            }
            return new RedirectToPageResult("LogIn");
        }
    }
}
