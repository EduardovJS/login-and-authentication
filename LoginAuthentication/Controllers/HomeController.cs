using LoginAuthentication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LoginAuthentication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
