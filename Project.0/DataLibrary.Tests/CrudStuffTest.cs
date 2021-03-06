
using System;
using System.Collections.Generic;
using DataLibrary;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataLibrary.Tests
{
    [PexClass(typeof(CrudStuff))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class CrudStuffTest
    {
        [PexMethod]
        public CrudStuff ConstructorTest()
        {
            CrudStuff target = new CrudStuff();
            return target;
            // TODO: add assertions to method CrudStuffTest.ConstructorTest()
        }

        [PexMethod]
        public Resturant FindRestByIDTest([PexAssumeUnderTest]CrudStuff target, int id)
        {
            Resturant result = target.FindRestByID(1);
            Assert.Equals(result.id, 1);

            return result;
            // TODO: add assertions to method CrudStuffTest.FindRestByIDTest(CrudStuff, Int32)

        }
