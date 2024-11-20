#region

using NUnit.Framework;

#endregion

namespace 单元测试_上课演示_2021FALL {

    [TestFixture]
    public class CalculatorTest {
        [SetUp]
        public void SetUp() {
            _calculator = new Calculator();
        }

        [TearDown]
        public void TearDown() {
            // do nothing
        }

        private Calculator _calculator;

        [Test]
        public void AddTest() {
            Assert.AreEqual(8, _calculator.Add(3, 5));
            Assert.AreEqual(-8, _calculator.Add(-3, -5));
            Assert.AreEqual(2, _calculator.Add(-3, 5));
            Assert.AreEqual(-2, _calculator.Add(3, -5));
            Assert.AreEqual(0, _calculator.Add(0, 0));
        }

        [Test]
        public void SubTest() {
            Assert.AreEqual(-2, _calculator.Sub(3, 5));
            Assert.AreEqual(2, _calculator.Sub(-3, -5));
            Assert.AreEqual(-8, _calculator.Sub(-3, 5));
            Assert.AreEqual(8, _calculator.Sub(3, -5));
            Assert.AreEqual(0, _calculator.Sub(0, 0));
        }

        [Test]
        public void DivTest() {
            Assert.Throws<DivideByZeroException>(() => { _calculator.Div(6, 0); });
        }
    }
}