using ASP_MVC.Handlers.ActionFilters;
using ASP_MVC.Mappers;
using ASP_MVC.Models.User;
using BLL.Entities;
using Common.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;

namespace ASP_MVC.Controllers
{
    public class UserController : Controller
    {
        // injection service
        private IUserRepository<User> _userService;
        public UserController(IUserRepository<User> userService)
        {
            _userService = userService;
        }

        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        // affichage compte utilisateur
        public ActionResult Details(Guid id)
        {
            try
            {
                UserDetails model = _userService.Get(id).ToDetails();
                return View(model);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // création compte
        [AnonymousNeeded]
        public ActionResult Create()
        {
            return View();
        }

        // traitement création compte
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserCreateForm form)
        {
            try
            {
                // ajout erreur formulaire si n'accepte pas les conditions d'utilisation
                if (!form.Consent) ModelState.AddModelError(nameof(form.Consent), "You must read and accept the Terms and Conditions");
                // gestion des erreurs du formulaire
                if (!ModelState.IsValid) throw new ArgumentException(nameof(form));

                Guid id = _userService.Insert(form.ToBLL());
                return RedirectToAction(nameof(Details), new { id = id });
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
