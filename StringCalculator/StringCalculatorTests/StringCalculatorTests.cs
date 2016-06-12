using NUnit.Framework;
using System;

namespace Calculator.Tests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        private StringCalculator calc;

        [SetUp]
        public void Intialize()
        {
            calc = new StringCalculator();
        }

        [Test]
        [TestCase("")]
        public void Add_EmptyString_Test(string value)
        {
            Assert.That(0, Is.EqualTo(calc.Add(value)));
        }

        [Test]
        [TestCase("1")]
        public void Add_SingleParam_Test(string value)
        {
            Assert.That(1, Is.EqualTo(calc.Add(value)));
        }

        [Test]
        [TestCase("1,2")]
        public void Add_TwoParam_Test(string value)
        {
            Assert.That(3, Is.EqualTo(calc.Add(value)));
        }

        [Test]
        [TestCase("1,2,3,4,5")]
        public void Add_MultipleParams_Test(string value)
        {
            Assert.That(15, Is.EqualTo(calc.Add(value)));
        }

        [Test]
        [TestCase("1\n2")]
        public void Add_NewLinesDelim_Test(string value)
        {
            Assert.That(3, Is.EqualTo(calc.Add(value)));
        }

        [Test]
        [TestCase("1\n2,3\n4,5")]
        public void Add_MultipleCharDelims_Test(string value)
        {
            Assert.That(15, Is.EqualTo(calc.Add(value)));
        }

        [Test]
        [TestCase("//;\n1;2")]
        public void Add_PrefixDelim_Test(string value)
        {
            Assert.That(3, Is.EqualTo(calc.Add(value)));
        }

        [Test]
        [TestCase("-1,-2")]
        [TestCase("-1,-2,3,4")]
        public void Add_NegativeParams_Test(string value)
        {
            Assert.Throws<InvalidOperationException>(() => calc.Add(value));
        }

        [Test]
        [TestCase("1000")]
        public void Add_SingleThousand_Test(string value)
        {
            Assert.That(0, Is.EqualTo(calc.Add(value)));
        }

        [Test]
        [TestCase("1,1001,1002")]
        public void Add_MultipleThousands_Test(string value)
        {
            Assert.That(1, Is.EqualTo(calc.Add(value)));
        }

        [Test]
        [TestCase("//[***]\n1***2***3")]
        public void Add_PrefixStringDelim_Test(string value)
        {
            Assert.That(6, Is.EqualTo(calc.Add(value)));
        }

        [Test]
        [TestCase("//[*][%]\n1*2%3")]
        public void Add_PrefixMultipleCharDelims_Test(string value)
        {
            Assert.That(6, Is.EqualTo(calc.Add(value)));
        }

        [Test]
        [TestCase("//[***][%%%][&*%]\n1***2%%%3&*%4")]
        public void Add_PrefixMultipleStringDelims_Test(string value)
        {
            Assert.That(10, Is.EqualTo(calc.Add(value)));
        }
    }
}
