using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            var movies = new Movies() { Name = "Sharks!" };
            return View(movies);
        }
    }
}
