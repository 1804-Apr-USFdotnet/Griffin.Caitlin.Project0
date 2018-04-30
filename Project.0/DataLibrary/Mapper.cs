using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resturant_Library;

namespace DataLibrary
{
    class Mapper
    {
     Resturant_Library.Resturant ConvertResturantfromDb (Resturant rest)
        {
            Resturant_Library.Resturant result = new Resturant_Library.Resturant();
            result.City = rest.City;
            result.Reviews = new List<ResturantReviews>();
            foreach(ResturantReview o in rest.ResturantReviews)
            {
                Resturant_Library.ResturantReviews review = new Resturant_Library.ResturantReviews();
                review.Review_ID = o.Review_ID;
                review.ReviewComment = o.ReviewComment;
                review.Reviewer = o.Reviewer;
                review.StarRating = o.StarRating;
                review.Resturant_ID = o.Resturant_ID; 
                

                result.Reviews.Add(review);
            }

            result.State = rest.State;
            result.Street = result.Street;
            result.City = result.City;
            result.id = result.id;
            result.AverageRating = result.AverageRating;

            return result;
        }
    }
}
