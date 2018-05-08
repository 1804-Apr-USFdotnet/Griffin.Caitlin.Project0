using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;
using Newtonsoft.Json;
using NLog;


namespace Resturant_Library //DELETE
{
    public class ClientBusinessMidMan
    {
        Logger log = LogManager.GetCurrentClassLogger();

        CrudStuff cs = new CrudStuff();
        Sorter sorts = new Sorter();
        List<DataLibrary.Resturant> list;
        List<Resturant_Library.Resturant> converted;


        public List<Resturant> ShowResturantsbyRating() 
        {
            list = cs.ShowResturantsByRating().ToList();
            converted = Connector.ConvertDataListtoLibraryList(list).ToList();
            return converted;
        }

    }
}
