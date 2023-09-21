using Microsoft.AspNetCore.Mvc;

namespace EcommerceWithAngularWeb.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
