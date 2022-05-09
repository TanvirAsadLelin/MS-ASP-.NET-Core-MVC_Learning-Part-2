using Microsoft.AspNetCore.Mvc;
using StringLength_ValidationAttribute.Models;

namespace StringLength_ValidationAttribute.Controllers
{   [Route("[controller]")]
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
