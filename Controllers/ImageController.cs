using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ImageController : Controller
    {
        [HttpGet]
        public IActionResult Index(string pokemon)
        {
            ViewData["pokemon"] = pokemon ?? "ball.png";
            return View();
        }
        [HttpPost]
        [ActionName("Index")]
        public IActionResult IndexPost(string pokemon)
        {
            ViewData["pokemon"] = pokemon;
            return View();
        }
    }
}
