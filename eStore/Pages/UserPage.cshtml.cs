using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eStore.Pages
{
    [Authorize]
    public class UserPageModel : PageModel
    {
        public void OnGet()
        {
            if(HttpContext.Session.GetString("user") != null) 
            {
                string[] sessionValue = HttpContext.Session.GetString("user").Split("-");
                if (sessionValue[1] != "Customer")
                {
                    Response.Redirect("LogIn");
                }
            }
            else Response.Redirect("LogIn");
        }
    }
}
