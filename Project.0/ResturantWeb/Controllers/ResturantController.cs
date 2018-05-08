
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using Resturant_Library;
using Microsoft.Ajax.Utilities;

namespace ResturantWeb.Controllers
{

    public class ResturantController : Controller
    {
        Sorter sort = new Sorter();
        List<Resturant> allResturants = (List<Resturant>)Connector.AllResturants();
        // GET: Resturant
        [HttpGet] // default type of Action
        public ActionResult Index(string search)
        {
            string query = Request.QueryString["search"];
            if (query.IsNullOrWhiteSpace())
            {
                if (search.IsNullOrWhiteSpace())
                {
                    return View(Connector.AllResturants());
                }
                return View(sort.FindResturantbyName(Connector.AllResturants().ToList(),search));
            }
            return View(sort.FindResturantbyName(Connector.AllResturants().ToList(), query));
        }

        public ActionResult Top3Resturants()
        {
            return View(sort.ShowResturantsbyRating(allResturants));
        }
        public ActionResult OrderbyAsc()
        {
            return View(sort.SortbyNameAsc(allResturants));
        }
            

        // GET: Resturant/Details/5
        public ActionResult ResturantDetails(int id)
        {
            return View(Connector.FindResturantsByID(id));
        }

        // GET: Resturant/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Resturant/Create
        [HttpPost] 
        public ActionResult Create(FormCollection infoforCreate)
        {
            try //<-----if not model state is not valid, redirect to index server side validation ***********IMPORTANT*******
            {
                Resturant create = new Resturant
                {
                    // TODO: Add insert logic here
                    Name = infoforCreate["name"],
                    City = infoforCreate["city"],
                    State = infoforCreate["state"],
                    Street = infoforCreate["Street"],
                };

                Connector.AddResturant(create);
                return RedirectToAction("Index");
            }           
            catch
            {
                return View();
            }           
        }

        public ActionResult Edit(int id)
        {
            return View(Connector.FindResturantsByID(id));
        }
        // POST: Resturant/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection Edit)
        {
            try
            {
                Resturant edit = new Resturant
                {
                    Name = Edit["name"],
                    City = Edit["city"],
                    State = Edit["state"],
                    Street = Edit["Street"],
                };
                var Id = Convert.ToInt32(Edit["id"]);
                Connector.EditResturant(edit, Id);
                return RedirectToAction("Index");
            }
            catch (Exception E)
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
        public ActionResult Delete(int id, FormCollection form)
        {
            try
            {
                // TODO: Add delete logic here
                Connector.DeleteResturant(id);
                return RedirectToAction("Index");
            }
            catch(Exception E)
            {
                return View();
            }
        }        
    }
}
