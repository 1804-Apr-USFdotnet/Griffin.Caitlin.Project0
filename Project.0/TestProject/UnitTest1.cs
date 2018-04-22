using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Resturant_Library;


namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            Resturant NewResturant = new Resturant();           // Arrange
            ResturantReviews NewReview = new ResturantReviews();

            NewResturant.NewReview(NewReview); //Act

            Assert.AreEqual(1, NewResturant.ListofReviews.Count);  //Assert

        }
    }
}
