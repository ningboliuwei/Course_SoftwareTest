using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace 上课演示_2022_FALL
{
    [TestFixture]
    public class CalculatorTest {
        private Calculator _calculator;

        [SetUp]
        public void Initialize() {
            _calculator = new Calculator();
        }

        [TearDown]
        public void Finalize()
        {
            _calculator = new Calculator();
        }


        [Test]
        public void AddTest() {
           
            Assert.AreEqual(8, _calculator.Add(3,5));
            Assert.AreEqual(12, _calculator.Add(5, 7));
        }

        [Test]
        public void SubTest()
        {
            var calculator = new Calculator();
            Assert.AreEqual(-2, _calculator.Sub(3, 5));
            Assert.AreEqual(-2, _calculator.Sub(5, 7));
        }
    }
}
