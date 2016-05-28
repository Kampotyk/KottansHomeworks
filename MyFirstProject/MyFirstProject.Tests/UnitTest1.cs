using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstProject1;

namespace MyFirstProject.Tests
{
    [TestClass]
    public class DateTimeTests
    {
        [TestMethod]
        public void IsLeapYear_1900_ReturnFalse()
        {
            var date = new DateTime(1900, 1, 1);
            bool result = date.isLeapYear();
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IsLeapYear_2000_ReturnTrue()
        {
            var date = new DateTime(200, 1, 1);
            bool result = date.isLeapYear();
            Assert.AreEqual(true, result);
        }
    }
}
