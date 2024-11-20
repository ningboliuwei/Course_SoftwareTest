#region

using System.Collections;
using NUnit.Framework;

#endregion

namespace 单元测试_测试驱动开发_IntegerList__演示 {
    [TestFixture]
    public class IntegerListTest {
        [Test]
        public void TestListCreation() {
            var integerList = new IntegerList();
            Assert.IsNotNull(integerList);
        }

        [Test]
        public void TestTwoItemsAdd() {
            var integerList = new IntegerList();
            integerList.Add(5);
            integerList.Add(10);

            Assert.AreEqual(5, integerList[0]);
            Assert.AreEqual(10, integerList[1]);
            Assert.AreEqual(2, integerList.Count);
        }

        [Test]
        public void TestOneThousandItemsAdd() {
            var integerList = new IntegerList();

            for (var i = 0; i < 1000; i++) {
                integerList.Add(i);
            }

            Assert.AreEqual(1000, integerList.Count);
            for (var i = 0; i < 1000; i++) {
                Assert.AreEqual(i, integerList[i]);
            }
        }

        [Test]
        public void TestTwoItemsToString() {
            var integerList = new IntegerList();

            integerList.Add(5);
            integerList.Add(3);
            Assert.AreEqual("5,3", integerList.ToString());
        }

        [Test]
        public void TestForEach() {
            var integerList = new IntegerList();
            var numbersForCompare = new ArrayList();

            for (var i = 0; i < 10; i++) {
                integerList.Add(i);
                numbersForCompare.Add(i);
            }

            var j = 0;
            foreach (int n in integerList) {
                Assert.AreEqual(numbersForCompare[j], n);
                j++;
            }
        }
    }
}