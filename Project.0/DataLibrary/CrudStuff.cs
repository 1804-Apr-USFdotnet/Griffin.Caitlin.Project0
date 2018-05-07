using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;


namespace DataLibrary
{
    public class CrudStuff
    {
        ResturantDbEntities db = new ResturantDbEntities();
        public void editResturant(Resturant resturant, int id)
        {
            var rest = FindRestByID(id);
            rest.Name = resturant.Name;
            rest.State = resturant.State;
            rest.Street = resturant.Street;
            rest.City = resturant.City;
            rest.AverageRating = resturant.AverageRating;
            db.SaveChanges();            
        }
        public void deleteResturant(int id)
        {
            Resturant restdel = FindRestByID(id);
            db.Resturants.Remove(restdel);
            db.SaveChanges();
        }
        public void addResturant(Resturant resturant)
        {
            db.Resturants.Add(resturant);
            db.SaveChanges();
        }

        public void AddReview(ResturantReview review)
        {
            db.ResturantReviews.Add(review);
            db.SaveChanges();
        }
        public IEnumerable<ResturantReview>ShowReview(int id)
            {
            return db.ResturantReviews.Where(revs => revs.Resturant_ID== id).ToList(); //<---takes the review specific to that id and returns its specific reviews tied to that resturand id
            }
        public Resturant FindRestByID(int id)
        {
            Resturant returnrest = null;
            IEnumerable<Resturant> Find = db.Resturants.ToList();
            foreach (var item in Find)
            {
                if (item.id == id)
                {
                    returnrest = item;
                    // tell the db to grab the reviews for that item
                }
            }
            if (returnrest == null)
            {
                Console.WriteLine("no resturant");
            }
            return returnrest;
        }
        public List<Resturant> ShowResturants()
        {
            return db.Resturants.ToList();
        }
        public IEnumerable<Resturant> ShowResturantsByRating()
        {
            return db.Resturants.OrderByDescending(x => x.AverageRating).Take(3).ToList();
        }
        public IEnumerable<Resturant> ShowResturantsByName()
        {
            return db.Resturants.OrderByDescending(x => x.Name).Take(3).ToList();
        }
        public IEnumerable<Resturant> FindResturantbyName(string name)
        {
            return db.Resturants.Where(x => x.Name.Contains(name)).ToList();
        }
        public ResturantReview FindReviewbyId(int id)
        {
            ResturantReview returnrev = null;
           IEnumerable<ResturantReview> Find = db.ResturantReviews.ToList();
            foreach (var item in Find)
            {
                if (item.Review_ID == id)
                {
                    returnrev = item;
                    // tell the db to grab the reviews for that item
                }
            }
            if (returnrev == null)
            {
                Console.WriteLine("no resturant");
            }
            return returnrev;
        }
        
    }
    
}
