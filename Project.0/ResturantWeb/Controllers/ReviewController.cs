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
        public ActionResult Edit(int id, int rest)
        {
            ViewBag.id = rest;
            return View(Connector.FindReviewbyId(rest, id));
        }
        [HttpPost]
        public ActionResult Edit(int id,int rest, FormCollection collection)
        {
            try
            {
                ResturantReviews edit = new ResturantReviews
                {
                    Resturant_ID = Convert.ToInt32( collection["Resturant_ID"]),
                    Reviewer = collection["Reviewer"],
                    ReviewComment = collection["ReviewComment"],
                    StarRating=Convert.ToInt32( collection["StarRating"])
                    
                };
                //var StarRating = Convert.ToInt32(collection["StarRating"]);
                Connector.EditReview(edit, id);
                return RedirectToAction("Details/"+rest);
            }
            catch(Exception E)
            {
                return View();
            }
        }
        public ActionResult Delete(int id, int id2)
        {
            ViewBag.ResturantID = id;
            return View(Connector.FindReviewbyId(id,id2));
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
