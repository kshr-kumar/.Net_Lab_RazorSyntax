using Lab_RazorSyntax.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_RazorSyntax.Controllers
{
    public class UserController : Controller
    {
        protected static List<UserModel> Users = new List<UserModel>();
        public IActionResult Index()
        {
            return View(Users);
        }
        public IActionResult Create(int UserId, string Name, String Email)
        {
            if (UserId != 0 && !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Email))
            {
                UserModel user = new UserModel { UserId = UserId, Name = Name, Email = Email };
                Users.Add(user);
            }
            return RedirectToAction("Index");
        }
    }
}
