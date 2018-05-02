
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Resturant_Library;

namespace Resturant_Library.Tests
{
    [PexClass(typeof(ClientBusinessMidMan))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ClientBusinessMidManTest
    {
        [PexMethod]
        public ClientBusinessMidMan ConstructorTest()
        {
            ClientBusinessMidMan target = new ClientBusinessMidMan();
            return target;
            // TODO: add assertions to method ClientBusinessMidManTest.ConstructorTest()
        }

        [PexMethod]
        public void SelectionHandlerTest([PexAssumeUnderTest]ClientBusinessMidMan target)
        {
            target.SelectionHandler();
            // TODO: add assertions to method ClientBusinessMidManTest.SelectionHandlerTest(ClientBusinessMidMan)
        }
    }
}
