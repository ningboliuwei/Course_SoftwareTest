#region

using NUnit.Framework;

#endregion

namespace 单元测试_测试驱动开发_Money类__演示 {
    [TestFixture]
    internal class BankTest {
        [Test]
        public void TestGetRate() {
            var bank = new Bank();
            Assert.AreEqual(0.5, bank.GetRate("CHF", "USD"));
        }
    }
}