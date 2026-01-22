using MyPortfolio_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MyPortfolio_MVC.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
       
        MyPortfolioNet1Entities2 db = new MyPortfolioNet1Entities2();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TblAdmin model)
        {
            var value = db.TblAdmins.FirstOrDefault(x=>x.Email == model.Email && x.Password==model.Password);
            if(value==null)
            {
                ModelState.AddModelError("", "Email veya Şifre Hatali");
                return View(model);    // model form yazdıgımız user password direk geliyor kaybolmaz
            }
            
            FormsAuthentication.SetAuthCookie(value.Email, false);
            Session["email"] = value.Email;
            return RedirectToAction("Index" , "Category");
        }
    }
}