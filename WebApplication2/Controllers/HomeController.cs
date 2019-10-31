using HttpContextProject.Helpers;
using HttpContextProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HttpContextProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            // handle the request and do something  
            var requestHandler = new RequestHandler();
            requestHandler.HandleAboutRequest(); 

            ViewData["Message"] = "This is our default message for About Page!";
            return View();
        }
    }
}

namespace HttpContextProject.Helpers
{
    public class RequestHandler
    {
        internal void HandleAboutRequest()
        {
            // do something here  
        }
    }
}