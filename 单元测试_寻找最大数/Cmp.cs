using System;

using NUnit.Framework;

namespace 单元测试_寻找最大数
{
    internal class Cmp
    {
        public static int Largest(int[] list)
        {
            int index;
            int max = int.MinValue; //Original: MaxValue

            for (index = 0; index < list.Length; index++) //Original: list.Length-1
            {
                if (list[index] > max)
                {
                    max = list[index];
                }
            }
            return max;
        }
    }

    //[TestFixture]
    //class CmpTest
    //{
    //    [Test]
    //    public void LargestOf3()
    //    {
    //        Assert.AreEqual(10, Cmp.Largest(new int[] { 8, 9, 10 }));
    //        Assert.AreEqual(10, Cmp.Largest(new int[] { 9, 9, 10 }));
    //        Assert.AreEqual(10, Cmp.Largest(new int[] { 9, 10, 9 }));
    //        Assert.AreEqual(-1, Cmp.Largest(new int[] { -1, -2, -3 }));
    //        Assert.AreEqual(10, Cmp.Largest(new int[] { 10, 9, 8 }));

    [TestFixture]
    internal class TestLargest
    {
        [Test]
        public void LargestOf3()
        {
            Assert.AreEqual(9, Cmp.Largest(new int[] { 9, 8, 7 }));
            Assert.AreEqual(9, Cmp.Largest(new int[] { 8, 9, 7 }));
            Assert.AreEqual(9, Cmp.Largest(new int[] { 7, 8, 9 }));

          
        }

        //    }

        [Test]
        public void LargestOf2()
        {
            Assert.AreEqual(9, Cmp.Largest(new int[] { 9, 8 }));
            Assert.AreEqual(9, Cmp.Largest(new int[] { 8, 9 }));
            Assert.AreEqual(8, Cmp.Largest(new int[] { 7, 8 }));
        }

        [Test]
        public void TestDups()
        {
            Assert.AreEqual(9, Cmp.Largest(new int[] { 9, 7, 9, 8 }));
        }

        //}

        [Test]
        [Category("simple")]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestOne()
        {
            Assert.AreEqual(1, Cmp.Largest(new int[] { 1 }));
        }

        [Test]
        [Category("simple")]
        public void TestNegative()
        {
            Assert.AreEqual(-7, Cmp.Largest(new int[] { -9, -8, -7 }));
            Assert.AreEqual(8, Cmp.Largest(new int[] { -9, 8, 7 }));
        }
    }
}