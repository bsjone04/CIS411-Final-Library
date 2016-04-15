using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CIS411_Final_Library.Models;

namespace CIS411_Final_Library.Controllers
{
    public class RatesController : Controller
    {
         ApplicationDbContext db = new ApplicationDbContext();

        // GET: Rates
        public ActionResult Index([Bind(Prefix = "id")] int bookId)
        {
            var book = db.Books.Find(bookId);
            if (book != null)
            {
                return View(book);
            }
            return HttpNotFound();

         }

        [HttpGet]
        public ActionResult Create (int bookId)
        {
            return View();

        }

        [HttpPost]
        public ActionResult Create(Rate rate)
        {
            if (ModelState.IsValid)
            {
                db.Rates.Add(rate);
                db.SaveChanges();
                return RedirectToAction("Index", new { id = rate.BookId });
            }
            return View(rate);
        }

        //// GET: Rates/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Rate rate = db.Rates.Find(id);
        //    if (rate == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(rate);
        //}

            //// GET: Rates/Create
            //public ActionResult Create()
            //{
            //    return View();
            //}

            //// POST: Rates/Create
            //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
            //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
            //[HttpPost]
            //[ValidateAntiForgeryToken]
            //public ActionResult Create([Bind(Include = "RateID,Stars,Comment")] Rate rate)
            //{
            //    if (ModelState.IsValid)
            //    {
            //        db.Rates.Add(rate);
            //        db.SaveChanges();
            //        return RedirectToAction("Index");
            //    }

            //    return View(rate);
            //}

            //// GET: Rates/Edit/5
            //public ActionResult Edit(int? id)
            //{
            //    if (id == null)
            //    {
            //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //    }
            //    Rate rate = db.Rates.Find(id);
            //    if (rate == null)
            //    {
            //        return HttpNotFound();
            //    }
            //    return View(rate);
            //}

            //// POST: Rates/Edit/5
            //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
            //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
            //[HttpPost]
            //[ValidateAntiForgeryToken]
            //public ActionResult Edit([Bind(Include = "RateID,Stars,Comment")] Rate rate)
            //{
            //    if (ModelState.IsValid)
            //    {
            //        db.Entry(rate).State = EntityState.Modified;
            //        db.SaveChanges();
            //        return RedirectToAction("Index");
            //    }
            //    return View(rate);
            //}

            //// GET: Rates/Delete/5
            //public ActionResult Delete(int? id)
            //{
            //    if (id == null)
            //    {
            //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //    }
            //    Rate rate = db.Rates.Find(id);
            //    if (rate == null)
            //    {
            //        return HttpNotFound();
            //    }
            //    return View(rate);
            //}

            //// POST: Rates/Delete/5
            //[HttpPost, ActionName("Delete")]
            //[ValidateAntiForgeryToken]
            //public ActionResult DeleteConfirmed(int id)
            //{
            //    Rate rate = db.Rates.Find(id);
            //    db.Rates.Remove(rate);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
