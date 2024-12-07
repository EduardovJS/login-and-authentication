using Microsoft.AspNetCore.Mvc;

namespace LoginAuthentication.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
