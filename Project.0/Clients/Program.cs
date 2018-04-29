using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;
using Resturant_Library;


namespace Clients
{
    public class Program
    {
        static void Main(string[] args)
        {
            ResturauntContext c = new ResturauntContext();
            foreach( Resturant r in c.Resturants)
            {
                Console.WriteLine(r);
            }
            Console.WriteLine(c);
            Console.ReadLine();

        }
    }
}
