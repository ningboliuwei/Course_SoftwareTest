#region

using NUnit.Framework;

#endregion

namespace 单元测试_测试驱动开发_Money类__演示_2022 {
    [TestFixture]
    public class DollarTest {
        [Test]
        public void AmountTest() {
            var fiveDollar = new Dollar(5);
            Assert.AreEqual(5, fiveDollar.Amount);
        }

        [Test]
        public void TimesTest() {
            var fiveDollar = new Dollar(5);
            Assert.AreEqual(5000, fiveDollar.Times(1000));
        }
    }
}