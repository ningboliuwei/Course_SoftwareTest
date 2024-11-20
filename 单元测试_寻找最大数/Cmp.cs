#region

using NUnit.Framework;

#endregion

namespace 单元测试_寻找最大数 {
    internal class Cmp {
        public static int Largest(int[] list) {
            int index;
            var max = int.MinValue; //Original: MaxValue

            for (index = 0; index < list.Length; index++) //Original: list.Length-1
            {
                if (list[index] > max) {
                    max = list[index];
                }
            }

            return max;
        }
    }

    [TestFixture]
    internal class TestLargest {
        [Test]
        public void LargestOf3() {
            Assert.AreEqual(9, Cmp.Largest(new[] { 9, 8, 7 }));
            Assert.AreEqual(9, Cmp.Largest(new[] { 8, 9, 7 }));
            Assert.AreEqual(9, Cmp.Largest(new[] { 7, 8, 9 }));
        }

        //    }

        [Test]
        public void LargestOf2() {
            Assert.AreEqual(9, Cmp.Largest(new[] { 9, 8 }));
            Assert.AreEqual(9, Cmp.Largest(new[] { 8, 9 }));
            Assert.AreEqual(8, Cmp.Largest(new[] { 7, 8 }));
        }

        [Test]
        public void TestDups() {
            Assert.AreEqual(9, Cmp.Largest(new[] { 9, 7, 9, 8 }));
        }

        //}

        [Test]
        // [Category("simple")]
        // [ExpectedException(typeof(DivideByZeroException))]
        public void TestOne() {
            Assert.AreEqual(1, Cmp.Largest(new[] { 1 }));
        }

        [Test]
        // [Category("simple")]
        public void TestNegative() {
            Assert.AreEqual(-7, Cmp.Largest(new[] { -9, -8, -7 }));
            Assert.AreEqual(8, Cmp.Largest(new[] { -9, 8, 7 }));
        }
    }
}