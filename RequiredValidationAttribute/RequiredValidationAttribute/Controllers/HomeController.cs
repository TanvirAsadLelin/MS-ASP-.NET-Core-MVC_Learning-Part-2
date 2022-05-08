using Microsoft.AspNetCore.Mvc;
using RequiredValidationAttribute.Models;

namespace RequiredValidationAttribute.Controllers
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
            //if (ModelState.IsValid)
            //{
            //    return "Name: " + e.Name + "\n" + "Gender: " + e.Gender + "\n" + "Age: " + e.Age;
            //}
            //else
            //{
            //    return "Data is not valid.";
            //}
        }
    }
}
