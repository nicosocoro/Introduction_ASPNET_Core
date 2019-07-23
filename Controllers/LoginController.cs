using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NET_Core_Introduction.Models;
using NET_Core_Introduction.Models.Dummy;

namespace NET_Core_Introduction.Controllers
{
    public class LoginController : Controller
    {
        #region PROPERTIES
        //ViewData IDs
        const string str_vd_err_invalid_user = "Error_Login";

        const string str_err_invalid_user = "The user name or password you’ve entered doesn’t match any account. Please, try again.";

        #endregion

        #region ACTIONS
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult DummyCredentials()
        {
            dUser model = new dUser();
            ViewBag.lst_users = model.GetDummyUsers();

            return View();
        }

        public IActionResult GenerateTXT()
        {
// djqwidqw

            return DummyCredentials();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ErrorLogin()
        {
            ViewBag.LoginError = str_err_invalid_user;
            return View("Login");
        }

        [HttpPost]
        public ActionResult ValidateLogin(string pUserName, string pPassword)
        {
            dUser model = new dUser();
            bool b_exists = model.ValidateUser(pUserName, pPassword);

            //we force the Action to call the action Index() from HomeController
            if (b_exists)
            {
                ViewBag.LoginError = string.Empty;
                return RedirectToAction("Index", "Home");
            }

            else
                return (ActionResult)ErrorLogin();
        } 
        #endregion
    }
}
