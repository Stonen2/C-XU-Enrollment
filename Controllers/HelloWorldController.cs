using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test3.Controllers
{
    public class HelloWorldController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
        public string testing()
        {



            return "I hate when i understand things. i really do " +
                "haha\n" +
                "this is kidna nice\n" +
                "is this java?" +
                "or C#";
        }

        public string test2(string h)
        {
            return h + "  This is how you pass parameters!";
        }
    }
}
