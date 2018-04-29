using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Resturant_Library;
using Serialization;
using System.Data.SqlClient;

namespace DataLibrary
{
    class DBInit : CreateDatabaseIfNotExists<ResturauntContext> //---------------this will connect the serealized data to the database-------------------
    {
        protected override void Seed(ResturauntContext context)
        {
            var resturant1 = new Resturant
            {
                id = 1,
                Name = "McRonalds",
                City = "A Town",
                State = "The Best State",
                Street = " Street Road Place",
                AverageRating = 0
            };

            var review1 = new ResturantReviews
            {
                Review_ID = 1,
                Resturant_ID = 1,
                Reviewer = "All Might",
                StarRating = 5,
                ReviewComment = " The burger I had was PLUS ULTRA!!!"

            };

            var resturant2 = new Resturant
            {
                id = 2,
                Name = "McRonalds",
                City = "A Town",
                State = "The Best State",
                Street = " Street Road Place",
                AverageRating = 0
            };

            var review2 = new ResturantReviews
            {
                Review_ID = 1,
                Resturant_ID = 1,
                Reviewer = "All Might",
                StarRating = 5,
                ReviewComment = " The burger I had was PLUS ULTRA!!!"

            };


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
            context.Resturants.Add(resturant1);
            context.Reviews.Add(review1);
            context.Resturants.Add(resturant2);
            context.Reviews.Add(review2);

            base.Seed(context);
            context.SaveChanges();

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
