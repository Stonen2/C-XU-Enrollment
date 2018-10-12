using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

       //
        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome()
        {
            ViewData["Message"] =  "This is the Welcome action method...";
            return View(); 

        }
    }
}