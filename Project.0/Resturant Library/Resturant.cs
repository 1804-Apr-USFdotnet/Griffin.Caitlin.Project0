﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Resturant_Library

{   
    public class Resturant
    {

        private string id;
        private string name;
        private string city;
        private string state;
        private string street;
        private string averageRating;


        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public double AverageRating { get; set; }


        public List<ResturantReviews> Reviews{ get; set; }

        //public Resturant() //constructor
        //{
        //    ListofReviews = new List<ResturantReviews>();
        //}
        //public void NewReview(ResturantReviews MyRview) //Method
        //{
        //   Reviews.Add(MyRview);
        //}

    }
    public class ResturantReviews // Reviews left by a customer
    {
        
        [Key]
        
        public int Review_ID { get; set; }
        public int Resturant_ID { get; set; }
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
   
}













