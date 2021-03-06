using System.Collections.Generic;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Resturant_Library;

namespace Resturant_Library.Tests
{
    [TestClass]
    public class ResturantSerializerTest
    {
        [TestMethod]
        public void loadJSONTest()
        {
            ResturantSerializer target = new ResturantSerializer();
            List<Resturant> result = target.loadJSON();
            Assert.IsTrue(result.Count > 0);
        }
    }
}
