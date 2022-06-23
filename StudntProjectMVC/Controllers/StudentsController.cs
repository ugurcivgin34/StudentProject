using StudntProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace StudntProjectMVC.Controllers
{
    public class StudentsController : Controller
    {
        private MyContext db = new MyContext();
        // GET: Student
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student Student = db.Students.Find(id);
            if (Student == null)
            {
                return HttpNotFound();
            }
            return View(Student);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student Student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(Student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Student);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student Student = db.Students.Find(id);
            if (Student == null)
            {
                return HttpNotFound();
            }
            return View(Student);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student Student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Student);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student Student = db.Students.Find(id);
            if (Student == null)
            {
                return HttpNotFound();
            }
            return View(Student);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student Student = db.Students.Find(id);
            db.Students.Remove(Student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

     

       


    }
}