using Microsoft.AspNetCore.Mvc;

namespace ModelBinding_Demo.Controllers
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

        [Route("[action]/{id?}")]
        public string Details(int id , string name)
        {
            return "Id: "+id +"\n" +"Name: "+name;
        }
    }
}
