using MyPortfolio_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MyPortfolio_MVC.Controllers
{
    public class EducationController : Controller
    {
        
        MyPortfolioNet1Entities2 db = new MyPortfolioNet1Entities2();


        public ActionResult Index()
        {
            var values = db.TblEducations.ToList();
            return View(values);
        }
    }
}