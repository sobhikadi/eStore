using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eStore.Pages
{
    public class EmployeePageModel : PageModel
    {
        public void OnGet()
        {
            if (HttpContext.Session.GetString("user") != null)
            {
                string[] sessionValue = HttpContext.Session.GetString("user").Split("-");
                if (sessionValue[1] != "Employee")
                {
                    Response.Redirect("LogIn");
                }
            }
            else Response.Redirect("LogIn");
        }
    }
}
