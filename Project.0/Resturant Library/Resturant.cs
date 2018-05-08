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
        [Required]
        [StringLength(10, ErrorMessage = "Review should not exceed 10")]
        public string Name { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Review should not exceed 10")]
        public string City { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Review should not exceed 10")]
        public string State { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Review should not exceed 10")]
        public string Street { get; set; }
        public double AverageRating {get;set;}
        public List<ResturantReviews> Reviews{ get; set; }
        public void GetAverageRating()
        {
            if(Reviews.Count != 0)
            {
                AverageRating = Reviews.Sum(x => x.StarRating) / Reviews.Count;
            }
            else
            {
                AverageRating = 0;
            }
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
        [Required]
        public string Reviewer
        {
            get; set;
        }
        [Required]
        [Range (0, 5)]
        public int StarRating
        {
            get; set;
        }
        [Required]
        [StringLength(150, ErrorMessage ="Review should not exceed 150 words")]
        public string ReviewComment
        {
            get; set;
        }
    }      
   
}













