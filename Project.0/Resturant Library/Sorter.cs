using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;

namespace Resturant_Library
{
    public class Sorter
    {
        CrudStuff Crud = new CrudStuff();
        public ICollection<Resturant> sorterconvert (List<DataLibrary.Resturant> tempz)
        {
            return Connector.ConvertDataListtoLibraryList(tempz);
        }

        public ICollection<Resturant>FindResturantbyName(List<Resturant>tempt, string name)
        {
            return (List<Resturant>)tempt.FindAll(x => x.Name.Contains(name));
        }
        public ICollection<Resturant> ShowResturantsbyRating(List<Resturant> temp)
        {
            return temp.OrderByDescending(x => x.AverageRating).Take(3).ToList();
        }
    }
    
}
