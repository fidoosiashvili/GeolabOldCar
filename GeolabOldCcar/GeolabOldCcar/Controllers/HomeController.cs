using GeolabOldCcar.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeolabOldCcar.Controllers
{
    public class HomeController : Controller
    {
        DataConnectDataContext db = new DataConnectDataContext();

        public ActionResult Index()
        {

            IndexModel model1 = new IndexModel();
            model1.SocialList = db.Socials.ToList();
            model1.IconList = db.Icons.ToList();
            model1.SliderList = db.Sliders.ToList();

            return View(model1);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult mail()
        {
            DataConnectDataContext db = new DataConnectDataContext();


            return View(db.Emails.ToList());
        }
    }
}