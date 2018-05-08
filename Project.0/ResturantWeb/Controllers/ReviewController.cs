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
        public ActionResult Details(int id)
        {
            ViewBag.ResturantID = id;
            return View(Connector.AllReviews(id));
        }
        public ActionResult Create(int id)
        {
            ViewBag.ResturantID = id;
            return View();
        }
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
        public ActionResult Edit(int id)
        {
            return View(Connector.FindReviewbyId(id));
        }//<---------Do Later
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
        public ActionResult Delete(int id, int id2)
        {
            ViewBag.ResturantID = id;
            return View(Connector.FindReviewbyId(id2));
        }
        [HttpPost]
        public ActionResult Delete(int id, int id2, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Connector.DeleteReview(id2);
                return RedirectToAction("Details/"+id);
            }
            catch
            {
                ViewBag.ResturantID = id;
                return View();
            }
        }
    }
}
