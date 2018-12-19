using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace NUnit_Demo
{
    [TestFixture]
    class CalculationTest
    {
        private Calculation _calculation;

        [SetUp]
        public void InitCalculation()
        {
            _calculation = new Calculation();
        }

        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(5, _calculation.Add(2, 3));
            Assert.AreEqual(-5, _calculation.Add(-2, -3));
            Assert.AreEqual(1, _calculation.Add(-2, 3));
            Assert.AreEqual(-2, _calculation.Add(-4, 2));
            Assert.AreEqual(0, _calculation.Add(0, 0));
        }

        [Test]
        public void TestSub()
        {
            Assert.AreEqual(-1, _calculation.Sub(2, 3));
            Assert.AreEqual(1, _calculation.Sub(-2, -3));
            Assert.AreEqual(-5, _calculation.Sub(-2, 3));
            Assert.AreEqual(-6, _calculation.Sub(-4, 2));
            Assert.AreEqual(0, _calculation.Sub(0, 0));
        }

        [Test]
        public void TestDivide()
        {
            Assert.AreEqual(3, _calculation.Divide(6, 2));
            Assert.AreEqual(1, _calculation.Divide(5, 5));
            Assert.AreEqual(2.5, _calculation.Divide(5, 2));
            Assert.AreEqual(2.6666667, _calculation.Divide(8, 3), 0.0001);
            //            Assert.AreEqual(float.MaxValue, _calculation.Divide(8, 0));
//            Assert.Throws<DivideByZeroException>(() => _calculation.Divide(8, 0));
        }
    }
}