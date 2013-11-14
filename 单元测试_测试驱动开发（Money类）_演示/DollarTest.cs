using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace 单元测试_测试驱动开发_Money类__演示
{
    [TestFixture]
    class DollarTest
    {
        [Test]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            five.Times(2);
            Assert.AreEqual(10, five.Amount);
        }

        [Test]
        public void TestFloatAmount()
        {
            Dollar fivePointThree = new Dollar(5.3);
            Assert.AreEqual(5.3, fivePointThree.Amount);
        }

        [Test]
        public void TestEqualsTo()
        {
            Dollar fiveDollar = new Dollar(5);
            Dollar anotherFiveDollar = new Dollar(5);

            Assert.AreEqual(true, anotherFiveDollar.EqualsTo(fiveDollar));
        }
    }
}