using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResturantWeb.Controllers;
using System.Web.Mvc;
using Resturant_Library;



namespace WebTests.Tests.Controllers
{
    /// <summary>
    /// Summary description for ResturantUnitTest
    /// </summary>
    [TestClass]
    public class ResturantUnitTest
    {
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void NameCheck()
        {
            ResturantController Controller = new ResturantController();

            var nameCheck = Controller.ResturantDetails(1110) as ViewResult;
            var actual = nameCheck.Model as Resturant;

            Assert.AreEqual("Demon Grill", actual.Name);
        }

        [TestMethod]
        public void EditCheck()
        {
            ResturantController Controller = new ResturantController();

            var editCheck = Controller.Edit(1110) as ViewResult;
            var actual = editCheck.Model;

            Assert.IsNotNull(actual);
        }
    }
}
