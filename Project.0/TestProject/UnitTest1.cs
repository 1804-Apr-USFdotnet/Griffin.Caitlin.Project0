using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Resturant_Library;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        private Resturant rest1 = new Resturant
        {

            Name = "Bobs Burgers",
            Id = 11,
            AverageRating = 2,
            City = "Molaton",
            State = "Qleren",
            Street = "Winmead",
        };

        private Resturant rest2 = new Resturant
        {
            Name = "resere",
            Id = 12,
            AverageRating = 6,
            City = "Appletons",
            State = "Michigan",
            Street = "Mossirinwind",
        };

        private Resturant rest3 = new Resturant
        {
            Name = "ROMM",
            Id = 3,
            AverageRating = 5,
            City = "Miserytown",
            State = "Releten",
            Street = "Sitinti",
        };

        [TestMethod]
        public void TestMethodCheckName()
        {
            Resturant NewResturant = new Resturant();
            NewResturant.Name = "Edamine"; //arrange
            string expected = NewResturant.Name;
            Assert.AreEqual(NewResturant.Name, expected);
            // Arrange
        }
        [TestMethod]
        public void TestMethodCheckCity()
        {
            Resturant NewCity = new Resturant();
            NewCity.City = "Boston";
            string expected = NewCity.City;
            Assert.AreEqual(NewCity.City, expected);
        }
        [TestMethod]
        public void TestRestaurantConstructor()
        {
            try
            {
                Resturant expected = new Resturant()
                {
                    Name = "resturant",
                    Id = 13,
                    AverageRating = 0,
                    City = "city",
                    State = "state",
                    Street = "street",
                };
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.Fail();
            }            
        }
        [TestMethod]
        public void TestClientBusinessMidMan()
        {
            ClientBusinessMidMan midMan = new ClientBusinessMidMan();
            Assert.IsInstanceOfType(midMan, typeof (ClientBusinessMidMan));
            //midMan.SelectionHandler(1);
        }
        [TestMethod]
        public void TestFindResturantByName()
        {
            List<Resturant>realList = new List<Resturant>();
            Sorter sorter = new Sorter();
            realList.Add(rest1);
            realList.Add(rest2);
            realList.Add(rest3);
            Resturant actual = realList[0];
            List<Resturant> expectedresturant = new List<Resturant>();
            expectedresturant = (List<Resturant>)sorter.FindResturantbyName(realList, "u");
            Resturant expected = expectedresturant[0];
            Assert.AreEqual(expected, actual);
        }

    }
            //Arrange
            //Act
            //Assert
        
    
}

