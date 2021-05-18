using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace 上课演示_2020_Fall
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator _calculator;

        [OneTimeSetUp]
        public void OneTimeSetUp() {
        }

        [SetUp]
        public void SetUp() {
            _calculator = new Calculator();
        }

        [TearDown]
        public void TearDown() {
        }

        [OneTimeTearDown]
        public void OneTimeTearDown() {
        }


        [Test]
        public void AddTest() {
            Assert.AreEqual(8, _calculator.Add(3, 5));
            Assert.AreEqual(-8, _calculator.Add(-3, -5));
            Assert.AreEqual(-2, _calculator.Add(3, -5));
            Assert.AreEqual(4, _calculator.Add(-3, 7));
        }

        [Test]
        public void SubTest() {
            Assert.AreEqual(-2, _calculator.Sub(3, 5));
            Assert.AreEqual(2, _calculator.Sub(-3, -5));
            Assert.AreEqual(8, _calculator.Sub(3, -5));
            Assert.AreEqual(-10, _calculator.Sub(-3, 7));
        }

        [Test]
        public void DivTest() {
            Assert.AreEqual(4, _calculator.Div(12, 3));
            Assert.Throws<DivideByZeroException>(() => _calculator.Div(12, 0));
        }
    }
}