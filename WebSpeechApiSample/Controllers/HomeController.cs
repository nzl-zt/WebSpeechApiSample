using Microsoft.AspNetCore.Mvc;

namespace WebSpeechApiSample.Controllers
{
    public class HomeController : Controller
    {
        // GET /Home/SpeechToText
        [HttpGet]
        public IActionResult SpeechToText()
        {
            return View();
        }
    }
}
