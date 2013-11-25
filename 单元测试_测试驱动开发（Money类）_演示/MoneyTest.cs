using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace 单元测试_测试驱动开发_Money类__演示
{
	class MoneyTest
	{
		[Test]
		public void TestMultiplication()
		{
			Money five = new Money(5);
			five.Times(2);
			Assert.AreEqual(10, five.Amount);
		}

		[Test]
		public void TestFloatAmount()
		{
			Money fivePointThree = new Money(5.3);
			Assert.AreEqual(5.3, fivePointThree.Amount);
		}


		[Test]
		public void TestEqualsTo()
		{
			Money five = new Money(5);
			Money anotherFive = new Money(5);

			Assert.AreEqual(true, five.EqualsTo(anotherFive));

		}

		[Test]
		public void TestEqualsToBetweenDollarAndFranc()
		{
			Dollar fiveDollar = new Dollar(5);
			Franc tenFranc = new Franc(10);

			Assert.AreEqual(true, fiveDollar.EqualsTo(tenFranc));
		}
	}
}
