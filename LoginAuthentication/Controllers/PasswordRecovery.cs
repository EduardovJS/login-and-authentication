using Microsoft.AspNetCore.Mvc;

namespace LoginAuthentication.Controllers
{
    public class PasswordRecovery : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
