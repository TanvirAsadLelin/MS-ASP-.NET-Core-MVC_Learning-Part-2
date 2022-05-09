using Microsoft.AspNetCore.Mvc;
using URL_MaxlengthMinlength_ValidationAttribute.Models;

namespace URL_MaxlengthMinlength_ValidationAttribute.Controllers
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
