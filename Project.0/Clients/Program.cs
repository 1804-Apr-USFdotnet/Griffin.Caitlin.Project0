using System;
using System.Collections.Generic;
using System.Linq;
using DataLibrary;
using NLog;


namespace Clients
{
    public class Program
    {
        static void Main(string[] args)
        {
            CrudStuff crudStuff = new CrudStuff();

            Logger log = LogManager.GetCurrentClassLogger();
            int ReviewSelection;
            CrudStuff cs = new CrudStuff();
            while ((ReviewSelection = GetReviewSelection()) != 6)
            {
                switch (ReviewSelection)
                {
                    case 1:
                        IEnumerable<DataLibrary.Resturant> list = cs.ShowResturantsByRating();
                        foreach (var list1 in list)
                        {
                            Console.WriteLine(list1.AverageRating + " " + list1.Name);
                        }
                        break;
                    case 2:
                        IEnumerable<DataLibrary.Resturant> name = cs.ShowResturants();
                        foreach (var name1 in name)
                        {
                            Console.WriteLine(name1.Name + " ");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter Id of Resturant");
                        int id = int.Parse(Console.ReadLine());
                        DataLibrary.Resturant rest = cs.FindRestByID(id);
                        try
                        {

                            Console.WriteLine(rest.id);
            Console.WriteLine(rest.Name);
            Console.WriteLine(rest.City);
            Console.WriteLine(rest.State);
            Console.WriteLine(rest.Street);
            Console.WriteLine(rest.AverageRating);
        }
                        catch
                        {
                            Console.WriteLine("That ID does not exist");
                            log.Error($"{id} that ID does not Exist");
                        }

                        break;
                    case 4:
                        Console.WriteLine("Enter Id of Resturant");
                        int i = int.Parse(Console.ReadLine());
    DataLibrary.Resturant restr = cs.FindRestByID(i);
                        try
                        {
                            foreach (var rev1 in restr.ResturantReviews)
                            {
                                Console.WriteLine(rev1.Review_ID + " " + rev1.ReviewComment);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("There is no ID for that Resturant");
                            log.Error($"{i} does not exist as a Resturant ID");
                        }
            break;
                    case 5:
                        Console.WriteLine("Enter the Resturant Name");
            string ResturantName = Console.ReadLine();

            {
                IEnumerable<DataLibrary.Resturant> by = cs.FindResturantbyName(ResturantName);
                if (by.Any())
                {
                    foreach (var rest1 in by)
                    {
                        Console.WriteLine(rest1.id + " " + rest1.Name);
                    }
                }
                else
                {
                    Console.WriteLine("There is no Resturant by that name");
                    log.Error($"{ResturantName} Does not Exist");
                }
            }
            break;


        }
    }

}

        private static int GetReviewSelection()
        {                       
            Console.WriteLine("1. Display top 3 Resturants");
            Console.WriteLine("2. Show all Resturants");
            Console.WriteLine("3. Show all Detils of Resturants");
            Console.WriteLine("4. Display all Reviews of a Resturant");
            Console.WriteLine("5. Show Resturants by Name");
            Console.WriteLine("6. End");
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("--------You have to type something------------");                
                GetReviewSelection();
                return 0;               
            }
        }
    }
}
