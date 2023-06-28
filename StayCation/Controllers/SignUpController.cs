using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using StayCation.Models;
using System.Diagnostics;

namespace StayCation.Controllers
{
    public class SignUpController : Controller
    {
        

        [HttpGet]
        public IActionResult Signing_up()
        {
            return View();
        }

        [HttpPost]
		public IActionResult Signing_up(User signup)
		{
            var fullname = signup.FullName;
            var email = signup.Email;
            var password = signup.PassWord;

            using (StreamWriter writer = new StreamWriter("Users.txt",true))
            {
                writer.WriteLine($" | {fullname} | {email}  | {password} |");
            };

			return RedirectToAction("LoginPage","Login");
		}
	}
}
