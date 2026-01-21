using MyPortfolio_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio_MVC.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        MyPortfolioNet1Entities2 db = new MyPortfolioNet1Entities2();
        public ActionResult Index()
        {
            string email = Session["email"].ToString();
            var admin = db.TblAdmins.FirstOrDefault(x=>x.Email == email); 
            return View(admin);
        }
    }
}