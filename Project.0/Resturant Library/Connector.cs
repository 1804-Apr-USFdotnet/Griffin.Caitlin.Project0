using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;

namespace Resturant_Library
{
    public static class Connector
    {
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


    }
    
}
