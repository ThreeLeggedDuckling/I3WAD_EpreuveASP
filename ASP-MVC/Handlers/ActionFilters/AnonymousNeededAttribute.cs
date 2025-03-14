using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ASP_MVC.Handlers.ActionFilters
{
    [AttributeUsage(AttributeTargets.Method)]
    public class AnonymousNeededAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            return;
        }

        // quand action marquée par l'attribut est appelée ...
        public void OnActionExecuting(ActionExecutingContext context)
        {
            // si pas de trace de l'utilisateur comme étant connecté, renvoie à l'accueil
            if (context.HttpContext.Session.GetString(nameof(SessionManager.ConnectedUser)) is not null) context.Result = new RedirectToActionResult("Index", "Home", null);
        }

    }
}
