using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrushuoLib.model;

namespace BrushupTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Person p = new Person("peter", 61, true);
            p.Age = -1;
            p.Name = "peter";

            Assert.AreEqual("peter", p.Name);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Person p = new Person("peter", 61, true);
            Assert.ThrowsException<ArgumentException>(() => p.Name = "pete");
            Assert.ThrowsException<ArgumentException>(()=> p.Name = null);
        }


    }
}
