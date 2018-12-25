using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrothersProjects.Controllers
{
    public class AuthenticationController : Controller
    {
        public ActionResult Authentication()
        {
            return View();
        }

        // GET: Authentication
        public ActionResult Login()
        {
            return View();
        }

        public void Authenticate()
        {
            if (ModelState.IsValid)
            {
                RedirectToAction("Login");
            }            
        }

        public ActionResult Logout()
        {
            return View();
        }

    }
}