using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Library
{
    public class Resturant
    {
        public List<ResturantReviews> ListofReviews { get; set; } //Everything involving resturant reviews
        public string ZipCode { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public int StreetNum { get; set; }
        public int ResturantID { get; set; }


        public Resturant() //constructor
        {
            ListofReviews = new List<ResturantReviews>();
        }
        public void NewReview(ResturantReviews MyRview) //Method
        {
            ListofReviews.Add(MyRview);
        }


    }
    public class ResturantReviews // Reviews left by a customer
    {
        public int StarReviews
        {
            get
            {
                return StarReviews;
            }
            set
            {
                if (value < 0 || value > 5)  //Made its max count for star reviews to 5
                {
                    if (value < 0)
                    {
                        StarReviews = 0;
                    }
                    else if (value > 5)
                    {
                        StarReviews = 5;
                    }
                }
                else StarReviews = value;
            }
        }

        public string WrittenReviews { get; set; }

    }
    public class ResturantReviewer // The customer itself leaving the review
    {
        public string Name { get; set; }
        public int CustomerID { get; set; }
        public string Comment { get; set; }
    }


    //public static class Serealizer(); im trying to make a serealizer
    
       
}



    
              
           


