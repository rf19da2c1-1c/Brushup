using System;
using BrushuoLib.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            Person p = new Person("SomeName",23,true);
            String expectedName = "Peter";

            // act
            p.Name = "Peter";
            string actualName = p.Name;

            //assert
            Assert.AreEqual(expectedName,actualName);

        }

        [TestMethod]
        public void TestMethod2()
        {
            // arrange
            Person p = new Person("SomeName", 23, true);

            // Act + assert
            Assert.ThrowsException<Exception>( ()=> p.Name = "pete" );


        }


    }
}
