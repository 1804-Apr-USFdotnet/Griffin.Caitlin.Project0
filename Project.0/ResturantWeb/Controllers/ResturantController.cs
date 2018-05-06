
using System.Web.Mvc;
using Resturant_Library;

namespace ResturantWeb.Controllers
{

    public class ResturantController : Controller
    {
        // GET: Resturant
        public ActionResult Index()
        {
            return View(Connector.AllResturants());
        }

        // GET: Resturant/Details/5
        public ActionResult ResturantDetails(int id)
        {
            return View(Connector.FindResturantsByID(id));
        }

        // GET: Resturant/Create
        public ActionResult Create()
        {
            return View();//<-----------!!!!wat   Connector.LibraryResttoDataRest()) save for later?
        }
        // POST: Resturant/Create
        [HttpPost]   //<-----------------put all the stuff in this
        public ActionResult Create([Bind(Include ="id, Name, City, State, Street, Average Rating")] Resturant infoforCreate)
        {
            try
            {
                // TODO: Add insert logic here
                var name = infoforCreate.Name;
                var id = infoforCreate.Id;
                var AverageRating = infoforCreate.AverageRating;
                var City = infoforCreate.City;
                var State = infoforCreate.State;
                var Street = infoforCreate.Street;




                return RedirectToAction("Index");
            }           
            catch
            {
                return View();
            }           
        }
        // GET: Resturant/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Connector.FindResturantsByID(id));
        }
        // POST: Resturant/Edit/5
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
        // GET: Resturant/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Connector.FindResturantsByID(id));
        }
        // POST: Resturant/Delete/5
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
