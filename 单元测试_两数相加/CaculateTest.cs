using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;


namespace 单元测试_两数相加
{
    [TestFixture]
    class CaculateTest
    {
        private int x;
        private int y;
        private Caculate caculate;

        [SetUp]
        public void IntializeNumbers()
        {
            x = -3;
            y = -4;
            caculate = new Caculate();
        }

        [TearDown]
        public void FinalizeNumbers()
        {
          //
        }


        [Test] //断言
        public void AddTwoNumbersTest()
        {
            Assert.AreEqual(-7, caculate.AddTwoNumbers(x, y));
            Assert.AreEqual(-6, caculate.AddTwoNumbers(x, y));
        }

        [Test]
        // [ExpectedException(typeof(DivideByZeroException))]
        public void DivideTwoNumbers()
        {
            Assert.AreEqual(3, caculate.DivideTwoNumbers(4,0));
        }

        [Test]
        public void FindBiggerTest()
        {
            Assert.AreEqual(-3, caculate.FindBigger(x, y));
            Assert.AreEqual(-3, caculate.FindBigger(-3, -5));
            Assert.AreEqual(5, caculate.FindBigger(5, 5));
        }
    }
}
