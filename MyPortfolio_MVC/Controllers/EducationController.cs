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

        public ActionResult DeleteEducation(int id)
        {
            var value = db.TblEducations.Find(id);
            db.TblEducations.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateEducation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateEducation(TblEducation model)
        {
            db.TblEducations.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var value = db.TblEducations.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateEducation(TblEducation modal)
        {
            var value = db.TblEducations.Find(modal.EducationId);
            value.SchollName = modal.SchollName;
            value.Description = modal.Description;
            value.StartDate = modal.StartDate;
            value.EndDate = modal.EndDate;
            value.Degree = modal.Degree;
            value.Department = modal.Department;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}