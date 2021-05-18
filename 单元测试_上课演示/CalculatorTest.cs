using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace 单元测试_上课演示
{
    [TestFixture]
    class CalculatorTest
    {
        private Calculator _calculator;

        [OneTimeSetUp]
        public void Initialize() {
            _calculator = new Calculator();
        }

        [Test]
        public void AddTest() {
            Assert.AreEqual(8, _calculator.Add(3,5));
            Assert.AreEqual(10.3, _calculator.Add(6.5, 3.8));
        }

        [Test]
        public void SubTest() {
            Assert.AreEqual(7, _calculator.Sub(10, 3));
            Assert.AreEqual(-2, _calculator.Sub(3, 5));
        }

        [Test]
        public void DivideTest() {
            Assert.AreEqual(10, _calculator.Divide(10, 1));
        }
    }
}
