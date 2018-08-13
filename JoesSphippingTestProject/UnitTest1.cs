using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JoesShipping;


//figure out why deebugging doesnt want to run "GetZone"
namespace JoesSphippingTestProject
{
    [TestClass]
    public class UnitTest1
    {
        //Cannot run test on methods that implements a prompt
        //[TestMethod]
        //public void TestZone()
        //{
        //    // Arrange 
        //    ItemPrice price = new ItemPrice();

        //    // Act
        //    string result = price.GetZone();
        //    string expectedResult = "Zone1";

        //    // Assert
        //    Assert.AreEqual(expectedResult,result);
        //}


        [TestMethod]
        public void should_methodName()
        {
            // Arrange 

            // Act
            type result = get_MethodName();
            type expectedResult = ;

            // Assert 
            Assert.Fail("Implement test");
            Assert.AreEqual(result, expectedResult);
        }
    }
}
