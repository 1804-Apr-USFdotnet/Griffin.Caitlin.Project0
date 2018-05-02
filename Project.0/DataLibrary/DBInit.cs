using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Serialization;
using System.Data.SqlClient;

namespace DataLibrary
{
    class DBInit : CreateDatabaseIfNotExists<ResturauntContext> //---------------this will connect the serealized data to the database-------------------
    {
        //protected override void Seed(ResturauntContext context)
        //{
        //    var resturant1 = new Resturant
        //    {
        //        id = 1,
        //        Name = "McRonalds",
        //        City = "A Town",
        //        State = "The Best State",
        //        Street = " Street Road Place",
        //        AverageRating = 5
        //    };

        //    var review1 = new ResturantReviews
        //    {
        //        Review_ID = 1,
        //        Resturant_ID = 1,
        //        Reviewer = "All Might",
        //        StarRating = 5,
        //        ReviewComment = " The burger I had was PLUS ULTRA!!!"

        //    };

        //    var resturant2 = new Resturant
        //    {
        //        id = 2,
        //        Name = "McRonalds",
        //        City = "C Town",
        //        State = "Number One State",
        //        Street = " Street Stuff",
        //        AverageRating = 5
        //    };

        //    var review2 = new ResturantReviews
        //    {
        //        Review_ID = 2,
        //        Resturant_ID = 1,
        //        Reviewer = "Deku",
        //        StarRating = 5,
        //        ReviewComment = "Its a really nice place to eat, I go here often AND I SAW ALL MIGHT!!! best day ever. . . "

        //    };
        //    var resturant3 = new Resturant
        //    {
        //        id = 3,
        //        Name = "Snapplebees",
        //        City = "Mootown",
        //        State = "State",
        //        Street = "Road",
        //        AverageRating = 0
        //    };

        //    var review3 = new ResturantReviews
        //    {
        //        Review_ID = 3,
        //        Resturant_ID = 2,
        //        Reviewer = "Becki",
        //        StarRating = 3,
        //        ReviewComment = " Hi, Im from accounting and I tried this vegan wrap, and it was really nice! though if I could make a suggestion, maybee a little more lettuce?"

        //    };

        //    var resturant4 = new Resturant
        //    {
        //        id = 4,
        //        Name = "Snapplebees",
        //        City = "Rowtown",
        //        State = "State Street",
        //        Street = "Rower",
        //        AverageRating = 0
        //    };

        //    var review4 = new ResturantReviews
        //    {
        //        Review_ID = 4,
        //        Resturant_ID = 2,
        //        Reviewer = "Mr.Spiteful",
        //        StarRating = 0,
        //        ReviewComment = "no"

        //    };

        //    var resturant5 = new Resturant
        //    {
        //        id = 4,
        //        Name = "Snapplebees",
        //        City = "Mooner",
        //        State = "Ahhh",
        //        Street = "BStreet",
        //        AverageRating = 0
        //    };

        //    var review5 = new ResturantReviews
        //    {
        //        Review_ID = 5,
        //        Resturant_ID = 2,
        //        Reviewer = "Mr.Goodman",
        //        StarRating = 5,
        //        ReviewComment = "Im sorry for my brothers attitude earlier, he had a bad day. Your food is great, dont listen to him."

        //    };


            //ResturantSerializer rs = new ResturantSerializer();
            //var data = rs.loadJSON();
            //for (int i = 0; i < data.Count; ++i)
            //{
            //    var resturant = data.ElementAt(i);
            //    context.Resturants.Add(resturant);
            //    for (int e = 0; e < resturant.Reviews.Count; ++e)
            //    {
            //        var review = resturant.Reviews.ElementAt(e);
            //        context.Reviews.Add(review);

            //    }
            //}
            //context.Resturants.Add(resturant1);
            //context.Reviews.Add(review1);
            //context.Resturants.Add(resturant2);
            //context.Reviews.Add(review2);
            //context.Resturants.Add(resturant3);
            //context.Reviews.Add(review3);
            //context.Resturants.Add(resturant4);
            //context.Reviews.Add(review4);
            //context.Resturants.Add(resturant5);
            //context.Reviews.Add(review5);

            //base.Seed(context);
            //context.SaveChanges();

            //SqlConnection conn = new SqlConnection();
            //using (SqlConnection myconn = new SqlConnection("Data Source=netcaitlin.cfikhgfy0lhl.us-east-2.rds.amazonaws.com;Initial Catalog=ResturantDB;Persist Security Info=True;User ID=sqladmin; Password= caitig9728;"))
            //{
            //    try
            //    {
            //        SqlCommand myCommand = new SqlCommand("")

            //    }
            //    catch
            //    {

            //    }

        }

     
            


        }

    
}
