using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Linq;

namespace Resturant_Library

{   
    public class Resturant//<---------------Resturant class, concrete class
    {


        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public double AverageRating {get;set;}
        public List<ResturantReviews> Reviews{ get; set; }
        public void GetAverageRating()
        {
            AverageRating = Reviews.Sum(x => x.StarRating) / Reviews.Count;
            //return result;

        }

        //public Resturant() //constructor <--------------Example, i keep it to use as reference
        //{
        //    ListofReviews = new List<ResturantReviews>();
        //}
        //public void NewReview(ResturantReviews MyRview) //Method
        //{
        //   Reviews.Add(MyRview);
        //}

    }
    public class ResturantReviews // Reviews left by a customer, concrete class
    {
        
        [Key]
        
        public int Review_ID { get; set; }
        public int Resturant_ID { get; set; }
        public string Reviewer
        {
            get; set;
        }
        [Range (0, 5)]
        public int StarRating
        {
            get; set;
        }
        public string ReviewComment
        {
            get; set;
        }
    }      
   
}













