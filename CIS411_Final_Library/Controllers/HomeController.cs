using CIS411_Final_Library.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIS411_Final_Library.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new Models.ApplicationDbContext();

        [AllowAnonymous]
        public ActionResult Index(string searchTerm = null)
        {
            var model =
                db.Books
               .OrderByDescending(r => r.Rates.Average(review => review.Stars))
               .Where(r => searchTerm ==null || r.Title.StartsWith(searchTerm))
               .Select( r => new BookListReview
                {
                    Id = r.BookID,
                    Title = r.Title,
                    CreationDate = r.CreationDate,
                    Quantity = r.Quantity,
                    Rate = r.Rates.Count()
                });

            return View(model);
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}