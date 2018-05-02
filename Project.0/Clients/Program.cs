using System;
using System.Collections.Generic;
using System.Linq;
using Resturant_Library;
using NLog;


namespace Clients
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClientBusinessMidMan midMan = new ClientBusinessMidMan();
            midMan.SelectionHandler();

        }
    }
}
