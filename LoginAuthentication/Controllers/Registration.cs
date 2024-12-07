using Microsoft.AspNetCore.Mvc;

namespace LoginAuthentication.Controllers
{
    public class Registration : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
