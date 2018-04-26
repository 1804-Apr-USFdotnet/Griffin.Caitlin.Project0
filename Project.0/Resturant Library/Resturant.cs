using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Library
{
    public class Resturant
    {
        public List<ResturantReviews> Reviews { get; set; } //Everything involving resturant reviews
        public string ZipCode { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public int Street_Num { get; set; }
        public int Resturant_ID { get; set; }


        //public Resturant() //constructor
        //{
        //    ListofReviews = new List<ResturantReviews>();
        //}
        //public void NewReview(ResturantReviews MyRview) //Method
        //{
        //    ListofReviews.Add(MyRview);
        //}


        public List<Resturant> loadJSON()
        {
            List<Resturant> resturants = new List<Resturant>();
            string json;
            using (StreamReader r = new StreamReader(@"C:\Revature\Griffin.Caitlin.Project0\ResturantStuff.txt"))
            {
                json = r.ReadToEnd();
                resturants = JsonConvert.DeserializeObject<List<Resturant>>(json);
            }
            return resturants;
        }



    }
    public class ResturantReviews // Reviews left by a customer
    {
        public string Reviewer
        {
            get; set;
        }
        public int StarRating
        {
            get; set;
        }
        public string ReviewComment
        {
            get; set;
        }
    }
    



    
    public class ResturantReviewer // The customer itself leaving the review
    {
        public string Name { get; set; }
        public int CustomerID { get; set; }
        public string Comment { get; set; }
    }
}













