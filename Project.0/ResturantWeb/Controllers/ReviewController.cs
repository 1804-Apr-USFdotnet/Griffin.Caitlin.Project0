using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Resturant_Library;

namespace ResturantWeb.Controllers
{
    public class ReviewController : Controller
    {
        // GET: Review
        //public ActionResult Index(int id)
        //{
        //    return View();
        //}

        // GET: Review/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.ResturantID = id;
            return View(Connector.AllReviews(id));
        }

        // GET: Review/Create
        public ActionResult Create(int id)
        {
            ViewBag.ResturantID = id;
            return View();
        }
        // POST: Review/Create
        [HttpPost]
        public ActionResult Create(int id, FormCollection create)
        {
            try
            {
                ResturantReviews add = new ResturantReviews
                {
                    Resturant_ID = int.Parse(create["Resturant_ID"]),
                    Reviewer = create["Reviewer"],
                    StarRating = int.Parse(create["StarRating"]), 
                    ReviewComment = create["ReviewComment"]
                };

                Connector.AddReview(add);
                return RedirectToAction("Details", new {id});
            }
            catch (Exception A )
            {
                ViewBag.ResturantID = id;
                return View();
            }
        }

        // GET: Review/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Connector.FindReviewbyId(id));
        }

        // POST: Review/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Review/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Connector.FindReviewbyId(id));
        }

        // POST: Review/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
