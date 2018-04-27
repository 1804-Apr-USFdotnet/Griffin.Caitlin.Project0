using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Resturant_Library;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Serialization
{
    public class ResturantSerializer
    {

        public List<Resturant> loadJSON()  //------------------Deserealized-----------------
        {
            List<Resturant> resturants = new List<Resturant>();
            string json;
            using (StreamReader r = new StreamReader(@"C:\Revature\Griffin.Caitlin.Project0\ResturantStuff.txt"))
            {
                json = r.ReadToEnd();
                resturants = JsonConvert.DeserializeObject<List<Resturant>>(json);
            }
            return resturants;
        }
    }
}
