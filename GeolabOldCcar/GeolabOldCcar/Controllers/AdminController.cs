using GeolabOldCcar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeolabOldCcar.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

       public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(LoginUser loginuser)
        {
            DataConnectDataContext db = new DataConnectDataContext();
            if (loginuser.email != null &&
                loginuser.password != null &&
                db.users.Where(x => x.Email == loginuser.email && x.Password == loginuser.password).FirstOrDefault() != null
                )
            {
                Session["userSesion"] = loginuser.email;
                return RedirectToAction("Index");
            }
            ViewBag.login = "მომხმარებლის იუზერი ან პაროლი არასწორია";
            return View();
        }
    }
}