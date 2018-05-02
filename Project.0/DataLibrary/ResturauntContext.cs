using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataLibrary
{
    public class ResturauntContext : DbContext  //------------------base pulls the connection automaticly, so this long string is pointless 
    {
        //public ResturauntContext() : base ("name=ResturantString") //------taking the stuff from the base constructor
        //{
        //    //this.Database.Connection.ConnectionString = "Data Source=ERNIE-LAPTOP;Initial Catalog=ResturantDb;Integrated Security=True";
        //    //Database.SetInitializer<ResturauntContext>(new DBInit());
        //}
        //public DbSet<Resturant> Resturants { get; set; }   
        //public DbSet<ResturantReviews> Reviews { get; set; }

            
    }


}
