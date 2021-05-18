using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using 上课演示_2021_SPRING;

namespace 上课演示_2021_SPRING_TEST
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator calculator = new Calculator();

        [SetUp]
        public void Setup() {

        }

        [TearDown]
        public void TearDown() {

        }

        [Test]
        public void AddTest() {
            Assert.AreEqual(8, calculator.Add(3, 5));
            Assert.AreEqual(-8, calculator.Add(-3, -5));
            Assert.AreEqual(2, calculator.Add(-3, 5));
        }

        [Test]
        public void SubTest() {
            Assert.AreEqual(-2, calculator.Sub(3, 5));
            Assert.AreEqual(2, calculator.Sub(-3, -5));
            Assert.AreEqual(-8, calculator.Sub(-3, 5));

        }
        //
        // [Test]
        // public void ArrayCompare() {
        //     var array1 = new int[] {1, 2, 3, 4, 5};
        //     var array2 = new int[] {1, 2, 3, 4, 5};
        //
        //     Assert.AreEqual(array1, array2);
        //     Assert.AreSame(array1, array2);
        // }
    }
}