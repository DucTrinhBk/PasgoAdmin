using PasgoWebAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PasgoWebAdmin.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Name,string Password,string ReturnUrl)
        {
            if(Name.Equals("ductd") && Password.Equals("Duc20091994"))
            {
                FormsAuthentication.SetAuthCookie(Name, true);
                return RedirectToAction("Index", "Home");
            }
            LoginUser user = new LoginUser();
            user.Name = Name;
            user.Password = Password;
            return View(user);

        }
    }
}