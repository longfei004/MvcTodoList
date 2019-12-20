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
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}