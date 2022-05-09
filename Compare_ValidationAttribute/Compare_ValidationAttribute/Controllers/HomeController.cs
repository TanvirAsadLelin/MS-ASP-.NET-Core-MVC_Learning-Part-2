using Compare_ValidationAttribute.Models;
using Microsoft.AspNetCore.Mvc;

namespace Compare_ValidationAttribute.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("~/")]
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Index(Employee e)
        {
            return View();

        }
    }
}
