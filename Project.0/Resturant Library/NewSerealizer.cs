
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
        }


    }

}
