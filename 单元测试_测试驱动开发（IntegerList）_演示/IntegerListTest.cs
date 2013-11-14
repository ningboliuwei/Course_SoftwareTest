using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单元测试_测试驱动开发_IntegerList__演示
{
	using System.Collections;

	using NUnit.Framework;

	[TestFixture]
	class IntegerListTest
	{
		[Test]
		public void TestListCreation()
		{
			IntegerList integerList = new IntegerList();
			Assert.IsNotNull(integerList);
		}

		[Test]
		public void TestTwoItemsAdd()
		{
			IntegerList integerList = new IntegerList();
			integerList.Add(5);
			integerList.Add(10);


			Assert.AreEqual(5, integerList[0]);
			Assert.AreEqual(10, integerList[1]);
			Assert.AreEqual(2, integerList.Count);
		}

		[Test]
		public void TestOneThousandItemsAdd()
		{
			IntegerList integerList = new IntegerList();

			for (int i = 0; i < 1000; i++)
			{
				integerList.Add(i);
			}

			Assert.AreEqual(1000, integerList.Count);
			for (int i = 0; i < 1000; i++)
			{
				Assert.AreEqual(i, integerList[i]);
			}
		}

		[Test]
		public void TestTwoItemsToString()
		{
			IntegerList integerList = new IntegerList();
			
			integerList.Add(5);
			integerList.Add(3);
			Assert.AreEqual("5,3", integerList.ToString());
		}

		[Test]
		public void TestForEach()
		{
			IntegerList integerList = new IntegerList();
			ArrayList numbersForCompare = new ArrayList();

			for (int i = 0; i < 10; i ++)
			{
				integerList.Add(i);
				numbersForCompare.Add(i);
			}


			int j = 0;
			foreach (int n in integerList)
			{
				Assert.AreEqual(numbersForCompare[j], n);
				j++;
			}
			
		}
	}
}
