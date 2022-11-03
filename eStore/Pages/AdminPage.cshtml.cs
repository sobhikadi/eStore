using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eStore.Pages
{
    [Authorize(Policy = "OnlyAdminAccess")]
    public class AdminPageModel : PageModel
    {
        public void OnGet()
        {
            if (HttpContext.Session.GetString("user") != null)
            {
                string[] sessionValue = HttpContext.Session.GetString("user").Split("-");
                if (sessionValue[1] != "Admin")
                {
                    Response.Redirect("LogIn");
                }
            }
            else Response.Redirect("LogIn");

        }
    }
}
