using System;
using System.Collections.Generic;
using System.Linq;
using DataLibrary;

namespace Resturant_Library
{
    public static class Connector
    {        
        static CrudStuff crud = new CrudStuff();
      
        public static void AddReview(ResturantReviews review)
        {
            var temp = LibraryReviewtoDataReview(review);
            crud.AddReview(temp);
        }


        public static void EditResturant(Resturant resturant, int id)
        {
            var edit = LibraryResttoDataRest(resturant);
            crud.editResturant(edit, id);
        }
        public static void DeleteResturant(int id)
        {
            var temp = LibraryResttoDataRest(FindResturantsByID(id));
            crud.deleteResturant(id);
        }
        public static void AddResturant(Resturant resturant)
        {
            var temp = LibraryResttoDataRest(resturant);
            crud.addResturant(temp);
        }
        public static Resturant_Library.Resturant DataResturanttoLibraryResturant(DataLibrary.Resturant dataset)
        {
            var libmodel = new Resturant_Library.Resturant() // converting information from the database for the resturant library to understand
            {
                Name = dataset.Name,
                Id = dataset.id,
                AverageRating = dataset.AverageRating,
                City = dataset.City,
                State = dataset.State,
                Street = dataset.Street
            };
             return libmodel;
        }
        public static ICollection<Resturant> ConvertDataListtoLibraryList(ICollection<DataLibrary.Resturant> Datalist)
        {
            ICollection<Resturant> rests = new List<Resturant>();
            foreach (DataLibrary.Resturant w in Datalist)
            {
                rests.Add(DataResturanttoLibraryResturant(w));
            }
            return rests;
        }
        public static ICollection<Resturant> AllResturants()
        {
            return ConvertDataListtoLibraryList(crud.ShowResturants());
        }
        public static Resturant FindResturantsByID(int i)
        {
            return DataResturanttoLibraryResturant(crud.FindRestByID(i));
        }//<--------Method to return the id of a resturant, used for searching
        public static ResturantReviews FindReviewbyId(int i)//<-------find Review by ID
        {
            return DataReviewtoLibraryReview(crud.FindReviewbyId(i));
        }

        public static ResturantReview LibraryReviewtoDataReview(ResturantReviews librevtodatrev)
        {
            var revdisp = new ResturantReview()
            {
                Review_ID = librevtodatrev.Review_ID,
                Resturant_ID = librevtodatrev.Resturant_ID,
                Reviewer = librevtodatrev.Reviewer,
                StarRating = librevtodatrev.StarRating,
                ReviewComment = librevtodatrev.ReviewComment
            };
            return revdisp;
        }
        public static ResturantReviews DataReviewtoLibraryReview(ResturantReview revset)
        {
            var revmodel = new ResturantReviews()
            {
                Review_ID = revset.Review_ID,
                Resturant_ID = revset.Resturant_ID,
                Reviewer = revset.Reviewer,
                StarRating = revset.StarRating,
                ReviewComment = revset.ReviewComment
            };
            return revmodel;
        } //converts a review from the data library to the resturant library
        public static ICollection<ResturantReviews> DataReviewListtoLibraryReviewList(ICollection<ResturantReview> datarev)
        {
            ICollection<ResturantReviews> revs = new List<ResturantReviews>();
            foreach(ResturantReview d in datarev)
            {
                revs.Add(DataReviewtoLibraryReview(d));
            }
            return revs;
        }
        public static ICollection<ResturantReviews> AllReviews(int id)
        {
            return DataReviewListtoLibraryReviewList(crud.ShowReview(id).ToList());
        }//<-----------Generates all reviews in a resturant
        public static DataLibrary.Resturant LibraryResttoDataRest (Resturant_Library.Resturant infoforCreate)//<---------used for creating resturants
        {
            var datamodel = new DataLibrary.Resturant() 
            {
                Name = infoforCreate.Name,
                id = infoforCreate.Id,
                AverageRating = infoforCreate.AverageRating,
                City = infoforCreate.City,
                State = infoforCreate.State,
                Street = infoforCreate.Street,
            };
            return datamodel;
        }        
    }   
}
