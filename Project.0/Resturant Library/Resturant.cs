using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Library
{
    public class Resturant
    {
        List <ResturantReviews> ListofReviews { get; set; } //Everything involving a resturant
        public string ZipCode { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public int StreetNum { get; set; }
        public int ResturantID { get; set; }
    }
    public class ResturantReviews // Reviews left by a customer
    {
        public int StarReviews { get; set; }
        public string WrittenReviews { get; set; }
    
    }
    public class ResturantReviewer // The customer itself leaving the review
    {
        public string Name { get; set; }
        public int CustomerID { get; set; }
    }

}
