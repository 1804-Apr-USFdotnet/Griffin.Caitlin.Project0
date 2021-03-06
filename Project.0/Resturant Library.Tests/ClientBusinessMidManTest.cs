// <copyright file="ClientBusinessMidManTest.cs">Copyright ©  2018</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Resturant_Library;

namespace Resturant_Library.Tests
{
    /// <summary>This class contains parameterized unit tests for ClientBusinessMidMan</summary>
    [PexClass(typeof(ClientBusinessMidMan))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ClientBusinessMidManTest
    {
        /// <summary>Test stub for SelectionHandler()</summary>
        [PexMethod]
        public void SelectionHandlerTest([PexAssumeUnderTest]ClientBusinessMidMan target)
        {
            target.SelectionHandler();
            // TODO: add assertions to method ClientBusinessMidManTest.SelectionHandlerTest(ClientBusinessMidMan)
        }
    }
}
