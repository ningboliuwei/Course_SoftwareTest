using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace 单元测试_测试驱动开发_Money类__演示
{

	[TestFixture]
	class FrancTest
	{
		[Test]
		public void TestMultiplication()
		{
			Franc five = new Franc(5);
			five.Times(2);
			Assert.AreEqual(10, five.Amount);
		}

		[Test]
		public void TestFloatAmount()
		{
			Franc fivePointThree = new Franc(5.3);
			Assert.AreEqual(5.3, fivePointThree.Amount);
		}


		[Test]
		public void TestEqualsTo()
		{
			Franc five = new Franc(5);
			Franc anotherFive = new Franc(5);

			Assert.AreEqual(true, five.EqualsTo(anotherFive));

		}

		[Test]
		public void TestCurrency()
		{
			Franc five = new Franc();
			Assert.AreEqual("CHF", five.Currency);
		}
	}
}
