using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class FormularzController : Controller
    {
        [HttpGet]
        public IActionResult Index(string name, string lname, string city)
        {
            ViewData["name"] = name ?? "Imie";
            ViewData["lname"] = lname ?? "Nazwisko";
            ViewData["city"] = city ?? "Miasto";
            return View();
        }
        [HttpPost]
        [ActionName("Index")]
        public IActionResult IndexPost(string name, string lname, string city)
        {
            ViewData["name"] = name;
            ViewData["lname"] = lname;
            ViewData["city"] = city;
            return RedirectToAction("Confirm", new { name, lname, city });
        }
        public IActionResult Confirm(string name, string lname, string city)
        {
            ViewData["name"] = name;
            ViewData["lname"] = lname;
            ViewData["city"] = city;

            return View();
        }
    }
}
