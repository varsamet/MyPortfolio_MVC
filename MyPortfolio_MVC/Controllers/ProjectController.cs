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

        [HttpGet]
        public ActionResult CreateProject()
        {
            var categoriList = db.TblCategories.ToList();
            List<SelectListItem> categories = (from x in categoriList
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();
            ViewBag.categories = categories;
            return View();
        }
    }
}