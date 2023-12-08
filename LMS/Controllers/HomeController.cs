using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LMS.Models;
using LMS.Filters;
using LMS.ViewModels.Home;
using LMS.ViewModels.Pager;
using LMS.DataAccess.Entities;
using LMS.DataAccess.Repositories;
using LMS.DataAccess.DataAccessLayer;
using DataAccess;

namespace LMS.Controllers
{    
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            LibraryManagementSystemContext context = new LibraryManagementSystemContext();
            UsersRepository usersRepo = new UsersRepository(context);            
            HomeIndexVM model = new HomeIndexVM();
            TryUpdateModel(model);

            if (AuthenticationManager.LoggedUser != null)
            {
                model.ID = AuthenticationManager.LoggedUser.ID;                
            }
           
            return View(model);
        }

        [HttpPost]        
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        public ActionResult Login(FormCollection collection)
        {
            var model = new HomeLoginVM();
            this.TryUpdateModel(model);

            AuthenticationManager.Authenticate(model.Email, model.Password);

            if (AuthenticationManager.LoggedUser == null)
            {
                this.ModelState.AddModelError("AuthenticationFailed", "* invalid or empty email or password");
                return View("Index");
            }
            else
            {
                Session["LoggedUser"] = model.Email;
                if (!string.IsNullOrEmpty(model.RedirectUrl))
                {
                    Response.Redirect(model.RedirectUrl);
                    return new EmptyResult();
                }
            }

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            AuthenticationManager.Logout();
            Session["LoggedUser"] = null;

            return RedirectToAction("Index", "Home");
        }
    }
}