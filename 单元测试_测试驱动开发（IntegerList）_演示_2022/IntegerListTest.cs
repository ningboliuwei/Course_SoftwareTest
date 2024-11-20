#region

using NUnit.Framework;

#endregion

namespace 单元测试_测试驱动开发_IntegerList__演示_2022 {
    [TestFixture]
    public class IntegerListTest {
        [Test]
        public void IntegerListCreationTest() {
            var list = new IntegerList();
            Assert.IsNotNull(list);
        }

        [Test]
        public void IntegerListAddTwoItemTest() {
            var list = new IntegerList();
            list.Add(3);
            list.Add(5);
            Assert.AreEqual(3, list[0]);
            Assert.AreEqual(5, list[1]);
        }

        [Test]
        public void IntegerListAddOneThousandItemsTest() {
            var list = new IntegerList();

            for (var i = 0; i < 1000; i++) {
                list.Add(i);
            }

            Assert.AreEqual(1000, list.Count);

            for (var i = 0; i < list.Count; i++) {
                Assert.AreEqual(i, list[i]);
            }
        }

        [Test]
        public void IntegerListToStringTest() {
            var list = new IntegerList();
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            Assert.AreEqual("3,4,5,6", list.ToString());
        }
    }
}