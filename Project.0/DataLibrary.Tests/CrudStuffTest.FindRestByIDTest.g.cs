using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLibrary;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace DataLibrary.Tests
{
    public partial class CrudStuffTest
    {

[TestMethod]
[PexGeneratedBy(typeof(CrudStuffTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void FindRestByIDTest01()
{
    CrudStuff crudStuff;
    Resturant resturant;
    crudStuff = new CrudStuff();
    resturant = this.FindRestByIDTest(crudStuff, 1);
}
    }
}
