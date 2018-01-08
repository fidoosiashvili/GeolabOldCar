using GeolabOldCcar.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeolabOldCcar.Controllers
{
    public class AdminController : Controller
    {
        DataConnectDataContext db = new DataConnectDataContext();

        // GET: Admin
        public ActionResult Index()
        {
            ViewBag.email = db.Emails.ToList().Count;
            ViewBag.services = db.Icons.ToList().Count;
            return View();
        }
        #region Login
        public ActionResult login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult login(LoginUser loginuser)
        {
            //   DataConnectDataContext db = new DataConnectDataContext();
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
        #endregion
        #region email
        [HttpPost]
        public ActionResult Email(Email model)
        {
            db.Emails.InsertOnSubmit(model);
            db.SubmitChanges();
            return RedirectToAction("Home/Index");
        }
        public ActionResult Email()
        {


            var EmailList = db.Emails.ToList();
            List<Mailmodel> mailmodel = new List<Mailmodel>();
            foreach (var t in EmailList)
            {
                mailmodel.Add(new Mailmodel { CreateDate = t.crateDate, EmailFrom = t.EmailFrom, Name = t.name, Id = t.Id });
            }
            return View(mailmodel);
        }
        public ActionResult EmailDetail(int id)
        {
            return View(db.Emails.Where(a => a.Id == id).FirstOrDefault());
        }
        #endregion
        public ActionResult Icon()
        {
            return View(db.Icons.ToList());
        }

        public ActionResult AddIcon()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddIcon( newIcon s)
        {
            try
            {
                Icon NewIcon = new Icon();
                string ext = Path.GetExtension(s.file1.FileName);
                string name = Tools.RandomString32();
                string url = Server.MapPath("~/Content/Image/" + name + ext);

               
                NewIcon.IconDesc = s.Name;

                NewIcon.IconName = name;

                NewIcon.iconExt = ext;
                db.Icons.InsertOnSubmit(NewIcon);
                db.SubmitChanges();
                s.file1.SaveAs(url);

                return RedirectToAction("Icon");
            }
            catch (Exception ex)
            {
                ViewBag.error = "დაფიქსირდა ხარვეზი ან ყველა ველი არ არის შევსებული";
                return View();
            }
        }
        public ActionResult IconDelete(int id)
        {
            db.Icons.DeleteOnSubmit((db.Icons.Where(a => a.Id == id).FirstOrDefault()));
            db.SubmitChanges();
            return RedirectToAction("Icon");

        }
        public ActionResult IconEdit(int id)
        {
            var t = db.Icons.Where(x => x.Id == id).FirstOrDefault();
            return View(t);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult IconEdit(newIcon s)
        {


            Icon update_post = db.Icons.Where(x => x.Id == s.id).FirstOrDefault();

            if (s.file1 is null)
            {
                update_post.IconDesc = s.Name;
                db.SubmitChanges();
            }
            else
            {
                string ext = Path.GetExtension(s.file1.FileName);
                string name = Tools.RandomString32();
                string url = Server.MapPath("~/Content/Image/" + name + ext);

                update_post.IconDesc = s.Name; update_post.IconName = name; update_post.iconExt = ext;
                db.SubmitChanges();
                s.file1.SaveAs(url);
            }

            return RedirectToAction("Icon");

        }
        #region Slider
        public ActionResult Slider()
        {
            return View(db.Sliders.ToList());
        }
        public ActionResult AddSlide()
        {
            return View();
        }
      
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddSlide(NewSlider slider)
        {
            try
            {
                Slider newSlider = new Slider();
                string ext = Path.GetExtension(slider.file1.FileName);
                string name = Tools.RandomString32();
                string url = Server.MapPath("~/Content/Image/" + name + ext);

                newSlider.date = slider.Date;

                newSlider.description = slider.Title;

                newSlider.SliderUrl = name;

                newSlider.SliderImageExt = ext;
                db.Sliders.InsertOnSubmit(newSlider);
                db.SubmitChanges();
                slider.file1.SaveAs(url);

                return RedirectToAction("Slider");
            }
            catch (Exception ex)
            {
                ViewBag.error = "დაფიქსირდა ხარვეზი ან ყველა ველი არ არის შევსებული";
                return View();
            }

        }
        public ActionResult SliderDelete(int id)
        {
            db.Sliders.DeleteOnSubmit((db.Sliders.Where(a => a.Id == id).FirstOrDefault()));
            db.SubmitChanges();
            return RedirectToAction("Slider");

        }
        public ActionResult SliderEdit(int id)
        {
            return View(db.Sliders.Where(x => x.Id == id).FirstOrDefault());
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SliderEdit(NewSlider s)
        {
           
                
                Slider update_post = db.Sliders.Where(x => x.Id == s.id).FirstOrDefault();

                if (s.file1 is null)
                {
                    update_post.description = s.Title; update_post.date = s.Date;
                    db.SubmitChanges();
                }
                else
                {
                    string ext = Path.GetExtension(s.file1.FileName);
                    string name = Tools.RandomString32();
                    string url = Server.MapPath("~/Content/Image/" + name + ext);

                    update_post.description = s.Title; update_post.date = s.Date; update_post.SliderUrl = name; update_post.SliderImageExt = ext;
                    db.SubmitChanges();
                    s.file1.SaveAs(url);
                }

                return RedirectToAction("Slider");
            
        }

        #endregion
        #region Social
        public ActionResult Social()
        {
            return View(db.Socials.ToList());
        }
        public ActionResult SocialEdit(int id)
        {
            return View(db.Socials.Where(a => a.id == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult SocialEdit(SocialEdit model)
        {

            Social Updated_Social = db.Socials.Where(a => a.id == model.Id).FirstOrDefault();
            Updated_Social.SocialUrl = model.SocialUrl; Updated_Social.SocialName = model.SocialName;
            db.SubmitChanges();

            return RedirectToAction("Social");

        }
        #endregion
    }
}