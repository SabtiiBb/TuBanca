using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TuBancaEnLinea.Models;

namespace TuBancaEnLinea.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                if(model.User == "Admin" && model.Password == "password")
                {
                    return RedirectToAction("", "");
                }
            }

            return View();
        }
    }
}