using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
	public class MovieController : Controller
	{
		public IActionResult Random()
		{
			var movie = new Movie() { Name = "Shrek" };

			return View();
		}
	}
}
