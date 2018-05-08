using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResturantWeb.Controllers;
using Resturant_Library;
using System.Web.Mvc;

namespace WebTests.Tests.Controllers
{
    /// <summary>
    /// Summary description for ReviewUnitTest
    /// </summary>
    [TestClass]
    public class ReviewUnitTest
    {
        public ReviewUnitTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

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
        public void ReviewerCheck()
        {
            ReviewController Controller = new ReviewController();

            var reviewerCheck = Controller.Edit(1551, 1110) as ViewResult;
            var actual = reviewerCheck.Model as ResturantReviews;

            Assert.AreEqual("Illidan", actual.Reviewer);
        }

        [TestMethod]
        public void ReviewModelIsNull()
        {
            ReviewController Controller = new ReviewController();

            var DeleteCheck = Controller.Edit(1, 1) as ViewResult;
            var actual = DeleteCheck.Model as ResturantReviews;

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void ReviewModelIsNotNull()
        {
            ReviewController Controller = new ReviewController();

            var DeleteCheck = Controller.Edit(1551, 1110) as ViewResult;
            var actual = DeleteCheck.Model as ResturantReviews;

            Assert.IsNotNull(actual);
        }
    }
}
