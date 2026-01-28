using MyPortfolio_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio_MVC.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: AdminLayout
        MyPortfolioNet1Entities2 db = new MyPortfolioNet1Entities2();
        public ActionResult Layout()
        {
            return View();
        }

        public PartialViewResult AdminLayoutHead()
        {
            return PartialView();
        }

        public PartialViewResult AdminLayoutSpinner()
        {
            return PartialView();
        }

        public PartialViewResult AdminLayoutSidebar()
        {
            if (Session["email"] == null)
            {
                return PartialView(); // ya da Redirect
            }

            var email = Session["email"].ToString();
            var admin = db.TblAdmins.FirstOrDefault(x => x.Email == email);

            return PartialView(admin);
        }

        public PartialViewResult AdminLayoutNavbar()
        {

            if (Session["email"] == null)
            {
                return PartialView(); // ya da Redirect
            }
            var email = Session["email"].ToString();
            var admin = db.TblAdmins.FirstOrDefault(x => x.Email == email);

            ViewBag.nameSurname = admin.Name + " " + admin.Surname;
            ViewBag.image = admin.ImageUrl;
            return PartialView();
        }

        public PartialViewResult AdminLayoutFooter()
        {
            return PartialView();
        }
        public PartialViewResult AdminLayoutScripts()
        {
            return PartialView();
        }
    }
}