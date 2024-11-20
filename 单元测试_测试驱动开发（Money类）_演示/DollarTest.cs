#region

using NUnit.Framework;

#endregion

namespace 单元测试_测试驱动开发_Money类__演示 {
    [TestFixture]
    internal class DollarTest {
        [Test]
        public void TestMultiplication() {
            var five = new Dollar(5);
            five.Times(2);
            Assert.AreEqual(10, five.Amount);
        }

        [Test]
        public void TestFloatAmount() {
            var fivePointThree = new Dollar(5.3);
            Assert.AreEqual(5.3, fivePointThree.Amount);
        }

        [Test]
        public void TestEqualsTo() {
            var five = new Dollar(5);
            var anotherFive = new Dollar(5);

            Assert.AreEqual(true, five.EqualsTo(anotherFive));
        }

        [Test]
        public void TestCurrency() {
            var five = new Dollar();
            Assert.AreEqual("USD", five.Currency);
        }
    }
}