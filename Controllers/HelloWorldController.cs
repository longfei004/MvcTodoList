using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcTodoList.Controllers
{
    public class HelloWorldController : Controller
    {
        // Get /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // Get /HelloWorld/Welcome/
        public IActionResult Welcome(string name, int  NumTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = NumTimes;

            return View();
        }
    }
}