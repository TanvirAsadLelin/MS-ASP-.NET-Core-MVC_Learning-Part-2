using Microsoft.AspNetCore.Mvc;

namespace RequiredValidationAttribute.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
