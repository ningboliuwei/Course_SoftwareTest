#region

using NUnit.Framework;

#endregion

namespace 单元测试_测试驱动开发_Money类__演示 {
    internal class MoneyTest {
        [Test]
        public void TestEqualsTo() {
            var five = new Money(5);
            var anotherFive = new Money(5);

            Assert.AreEqual(true, five.EqualsTo(anotherFive));
        }

        [Test]
        public void TestEqualsToBetweenDollarAndFranc() {
            var fiveDollar = new Dollar(5);
            var tenFranc = new Franc(10);

            Assert.AreEqual(true, fiveDollar.EqualsTo(tenFranc));
        }

        [Test]
        public void TestFloatAmount() {
            var fivePointThree = new Money(5.3);
            Assert.AreEqual(5.3, fivePointThree.Amount);
        }

        [Test]
        public void TestMultiplication() {
            var five = new Money(5);
            five.Times(2);
            Assert.AreEqual(10, five.Amount);
        }
    }
}