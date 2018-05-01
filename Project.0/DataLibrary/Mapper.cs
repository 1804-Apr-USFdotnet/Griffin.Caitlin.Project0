using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resturant_Library;

namespace DataLibrary
{
    public class Mapper
    {
        public static Resturant_Library.Resturant ConvertResturantfromDb(Resturant rest)
        {
            Resturant_Library.Resturant result = new Resturant_Library.Resturant();
            result.Reviews = new List<ResturantReviews>();
            foreach (ResturantReview o in rest.ResturantReviews)
            {
                Resturant_Library.ResturantReviews review = new Resturant_Library.ResturantReviews();
                review.Review_ID = o.Review_ID;
                review.ReviewComment = o.ReviewComment;
                review.Reviewer = o.Reviewer;
                review.StarRating = o.StarRating;
                review.Resturant_ID = o.Resturant_ID;
                result.Reviews.Add(review);
            }
            result.Name = rest.Name;
            result.State = rest.State;
            result.Street = rest.Street;
            result.City = rest.City;
            result.id = rest.id;
            result.AverageRating = rest.AverageRating;
            return result;
        }
        public static Resturant ConvertdbfromResturant(Resturant_Library.Resturant rest)
        {
            Resturant result = new Resturant();           
            result.ResturantReviews = new List<ResturantReview>();
            foreach (ResturantReviews t in rest.Reviews)
            {
                ResturantReview review = new ResturantReview();
                review.Review_ID = t.Review_ID;
                review.ReviewComment = t.ReviewComment;
                review.Reviewer = t.Reviewer;
                review.StarRating = t.StarRating;
                review.Resturant_ID = t.Resturant_ID;
                result.ResturantReviews.Add(review);
            }
            result.Name = rest.Name;
            result.State = rest.State;
            result.Street = rest.Street;
            result.City = rest.City;
            result.id = rest.id;
            result.AverageRating = rest.AverageRating;
            return result;
        }
    }
}
