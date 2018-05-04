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

        //public Resturant FindRestByID(int i)  // a function that takes the crud operation and takes it from the data library to the resturant library
        //{     ----------------USELESS-------------------------
           
        //    DataLibrary.Resturant restr = cs.FindRestByID(i);
        //    return Connector.DataResturanttoLibraryResturant(restr);
        //}

        public List<Resturant> ShowResturantsbyRating() // top 3 resturants----not yet!! need an extention of this, or an option at least
        {
            list = cs.ShowResturantsByRating().ToList();
            converted = Connector.ConvertDataListtoLibraryList(list).ToList();
            return converted;
        }

     

        //public List<ResturantReviews> GetResturantReviews

        //public void SelectionHandler() //<------this is a function
        //{
        //    int ReviewSelection;
        //    converted = (List<Resturant_Library.Resturant>)sorts.sorterconvert(cs.ShowResturants());
        //    while ((ReviewSelection = GetReviewSelection()) != 6)
        //    {


        //        //display top 3 restaurants by average rating
        //        //display all restaurants 
        //        //should allow more than one method of sorting
        //        //display details of a restaurant
        //        //display all the reviews of a restaurant

                

        //        switch (ReviewSelection)
        //        {
        //            case 1:
        //                 converted = (List<Resturant_Library.Resturant>)sorts.ShowResturantsbyRating(converted);
        //                foreach (var list1 in list)
        //                {
        //                    Console.WriteLine(list1.AverageRating + " " + list1.Name);
        //                }
        //                break;

        //            case 2:
        //                foreach (var name1 in converted)
        //                {
        //                    Console.WriteLine(name1.Name + " ");
        //                }
        //                break;

        //            case 3:
        //                Console.WriteLine("Enter Id of Resturant");
        //                int id = int.Parse(Console.ReadLine());
        //                DataLibrary.Resturant rest = cs.FindRestByID(id);
        //                try
        //                {
        //                    Console.WriteLine(rest.id);
        //                    Console.WriteLine(rest.Name);
        //                    Console.WriteLine(rest.City);
        //                    Console.WriteLine(rest.State);
        //                    Console.WriteLine(rest.Street);
        //                    Console.WriteLine(rest.AverageRating);
        //                }
        //                catch
        //                {
        //                    Console.WriteLine("That ID does not exist");
        //                    log.Error($"{id} that ID does not Exist");
        //                }
        //                break;
        //            case 4:
        //                Console.WriteLine("Enter Id of Resturant");
        //                int i = int.Parse(Console.ReadLine());
        //                DataLibrary.Resturant restr = cs.FindRestByID(i);
        //                try
        //                {
        //                    foreach (var rev1 in restr.ResturantReviews)
        //                    {
        //                        Console.WriteLine(rev1.Review_ID + " " + rev1.ReviewComment);
        //                    }
        //                }
        //                catch
        //                {
        //                    Console.WriteLine("There is no ID for that Resturant");
        //                    log.Error($"{i} does not exist as a Resturant ID");
        //                }
        //                break;
        //            case 5:
        //                Console.WriteLine("Enter the Resturant Name");
        //                string ResturantName = Console.ReadLine();

        //                {
        //                    converted= (List<Resturant_Library.Resturant>)sorts.FindResturantbyName(converted,ResturantName);
        //                    //if (sorts.(by))
        //                    //{
        //                        foreach (var rest1 in converted)
        //                        {
        //                            Console.WriteLine(rest1.Id + " " + rest1.Name);
        //                        }
        //                        //}
        //                        //else
        //                        //{
        //                        //    Console.WriteLine("There is no Resturant by that name");
        //                        //    log.Error($"{ResturantName} Does not Exist");
        //                        //}

        //                        break;
        //                }

        //        }
        //    }
        //}

        //private static int GetReviewSelection()
        //{
        //    Console.WriteLine("1. Display top 3 Resturants");
        //    Console.WriteLine("2. Show all Resturants");
        //    Console.WriteLine("3. Show all Detils of Resturants");
        //    Console.WriteLine("4. Display all Reviews of a Resturant");
        //    Console.WriteLine("5. Show Resturants by Name");
        //    Console.WriteLine("6. End");
        //    try
        //    {
        //        return int.Parse(Console.ReadLine());
        //    }
        //    catch
        //    {
        //        Console.WriteLine("--------You have to type something------------");
        //        GetReviewSelection();
        //        return 0;
        //    }

        //}
    }
}
