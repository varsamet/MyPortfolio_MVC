using MyPortfolio_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio_MVC.Controllers
{
    public class ProjectController : Controller
    {
        MyPortfolioNet1Entities2 db = new MyPortfolioNet1Entities2();
        public ActionResult Index()
        {
            var values = db.TblProjects.ToList();
            return View(values);
        }
    }
}