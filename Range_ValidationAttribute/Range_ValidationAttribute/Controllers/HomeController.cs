using Microsoft.AspNetCore.Mvc;
using Range_ValidationAttribute.Models;

namespace Range_ValidationAttribute.Controllers
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
