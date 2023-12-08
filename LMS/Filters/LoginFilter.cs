using System;
using System.Web.Mvc;
using LMS.Models;
using LMS.ViewModels.Home;

namespace LMS.Filters
{
    public class LoginFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewData["HomeLoginVM"] = new HomeLoginVM();
            
            base.OnActionExecuting(filterContext);
        }
    }
}