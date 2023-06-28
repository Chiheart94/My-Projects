using Microsoft.AspNetCore.Mvc;

namespace StayCation.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult LoginPage()
        {

            return View();
        }

    }
}
