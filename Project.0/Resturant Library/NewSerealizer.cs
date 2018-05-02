
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace Resturant_Library
{
    public class ResturantSerializer
    {

        public List<Resturant> loadJSON()  //------------------Deserealized-----------------
        {
            string json = File.ReadAllText(@"C:\Revature\Griffin.Caitlin.Project0\ResturantStuff.txt");
            var objects = JsonConvert.DeserializeObject<List<Resturant_Library.Resturant>>(json);
            return objects;

            //List<Resturant> resturants = new List<Resturant>();
            //string json;
            //using (StreamReader r = new StreamReader(@"C:\Revature\Griffin.Caitlin.Project0\ResturantStuff.txt"))
            //{
            //    json = r.ReadToEnd();
            //    resturants = JsonConvert.DeserializeObject<List<Resturant>>(json);
            //}
            //return resturants;
            //ResturantSerializer serializer = new ResturantSerializer(); //------Its sole Purpose is to put things into the database-------
            //var data = serializer.loadJSON();
            //int k = 0;
            //for (int i = 0; i < data.Count - 1; i++)
            //{
            //    var temp = new Resturant_Library.Resturant()
            //    {
            //        id = i + 1,
            //        State = data[i].State,
            //        City = data[i].City,
            //        Street = data[i].Street,
            //        Name = data[i].Name,
            //        AverageRating = data[i].AverageRating,
            //        Reviews = new List<Resturant_Library.ResturantReviews>()
            //    };
            //    for (int j = 0; j < data[i].Reviews.Count - 1; j++, k++)
            //    {
            //        var temp2 = new Resturant_Library.ResturantReviews()
            //        {
            //            Review_ID = k,
            //            Resturant_ID = i + 1,
            //            ReviewComment = data[i].Reviews[j].ReviewComment,
            //            Reviewer = data[i].Reviews[j].Reviewer,
            //            StarRating = data[i].Reviews[j].StarRating,

            //        };
            //        temp.Reviews.Add(temp2);
            //    }
            //    crudStuff.addResturant(temp);
            //}
        }


    }

}
