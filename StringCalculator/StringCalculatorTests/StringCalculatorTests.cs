using NUnit.Framework;
using System;

namespace StringCalculator.Tests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        private StringCalculator calc;

        [SetUp]
        public void Intialize()
        {
            //Arrange
            calc = new StringCalculator();
        }

        [Test]
        [TestCase("")]
        public void Add_EmptyString_Test(string value)
        {
            //Assert
            Assert.That(0, Is.EqualTo(calc.Add(value)));
        }

        [Test]
        [TestCase("1")]
        public void Add_SingleParam_Test(string value)
        {
            //Assert
            Assert.That(1, Is.EqualTo(calc.Add(value)));
        }

        [Test]
        [TestCase("1,2")]
        public void Add_TwoParam_Test(string value)
        {
            //Assert
            Assert.That(3, Is.EqualTo(calc.Add(value)));
        }

        [Test]
        [TestCase("1,2,3,4,5")]
        public void Add_MultipleParams_Test(string value)
        {
            //Assert
            Assert.That(15, Is.EqualTo(calc.Add(value)));
        }

        [Test]
        [TestCase("1\n2")]
        public void Add_NewLinesDelim_Test(string value)
        {
            //Assert
            Assert.That(3, Is.EqualTo(calc.Add(value)));
        }

        [Test]
        [TestCase("1\n2,3\n4,5")]
        public void Add_MultipleDelims_Test(string value)
        {
            //Assert
            Assert.That(15, Is.EqualTo(calc.Add(value)));
        }

        [Test]
        [TestCase("//;\n1;2")]
        public void Add_SetupDelim_Test(string value)
        {
            //Assert
            Assert.That(3, Is.EqualTo(calc.Add(value)));
        }
    }
}
