using ASP_MVC.Handlers;
using ASP_MVC.Handlers.ActionFilters;
using ASP_MVC.Models.Auth;
using BLL.Entities;
using Common.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC.Controllers
{
    public class AuthController : Controller
    {
        private IUserRepository<User> _userService;
        private SessionManager _sessionManager;
        public AuthController(IUserRepository<User> userService, SessionManager sessionManager)
        {
            _userService = userService;
            _sessionManager = sessionManager;
        }

        public IActionResult Index()
        {
            return RedirectToAction(nameof(Login));
        }

        [AnonymousNeeded]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AnonymousNeeded]
        public IActionResult Login(AuthLoginForm form)
        {
            try
            {
                if (!ModelState.IsValid) throw new ArgumentException(nameof(form));
                Guid id = _userService.CheckPassword(form.Email, form.Password);
                ConnectedUser user = new ConnectedUser()
                {
                    User_Id = id,
                    Email = form.Email,
                    connectedAt = DateTime.Now,
                };
                _sessionManager.Login(user);

                return RedirectToAction("Details", "User", new { id = id });
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        public IActionResult Logout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logout(IFormCollection form)
        {
            try
            {
                _sessionManager.Logout();
                return RedirectToAction(nameof(Login));
            }
            catch (Exception ex)
            {
                return View();
            }
        }

    }
}
