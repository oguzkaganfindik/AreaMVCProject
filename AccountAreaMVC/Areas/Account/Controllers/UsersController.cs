using AccountAreaMVC.Areas.Account.Data.Interface;
using AccountAreaMVC.Areas.Account.Models;
using Microsoft.AspNetCore.Mvc;

namespace AccountAreaMVC.Areas.Account.Controllers
{
    [Area("Account")]
    public class UsersController : Controller
    {
        private readonly IUserService _userRepo;

        public UsersController(IUserService userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(User user)
        {
            TempData["Success"] = _userRepo.LogIn(user);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult LogOut()
        {
            TempData["Success"] = _userRepo.LogOut();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            TempData["Success"] = _userRepo.Register(user);
            return RedirectToAction("Index");
        }
    }
}
