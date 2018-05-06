﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace DataLibrary
{
    public class CrudStuff
    {
        ResturantDbEntities db = new ResturantDbEntities();
        public void addResturant(Resturant resturant)
        {
            db.Resturants.Add(resturant);
            db.SaveChanges();
        }
        public IEnumerable<ResturantReview>ShowReview()
            {
            return db.ResturantReviews.ToList();
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

        
    }
    
}
