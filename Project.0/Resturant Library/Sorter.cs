using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;

namespace Resturant_Library
{
    public class Sorter     // ----takes the results and sorts the list results
    {
        CrudStuff Crud = new CrudStuff();
        public ICollection<Resturant> sorterconvert (List<DataLibrary.Resturant> tempz)
        {
            return Connector.ConvertDataListtoLibraryList(tempz);
        }
        public ICollection<Resturant>FindResturantbyName(List<Resturant>tempt, string name)
        {
            return (List<Resturant>)tempt.FindAll(x => x.Name.Contains(name));
            //use linq Where and multiple or statements with the =>
        }
        public ICollection<Resturant> ShowResturantsbyRating(List<Resturant> temp)
        {
            return temp.OrderByDescending(x => x.AverageRating).Take(3).ToList();
        }   
        
        public ICollection<Resturant> SortbyNameAsc(List<Resturant> asc)
        {
            return asc.OrderBy(x => x.Name).ToList();
        }
    }  
}
