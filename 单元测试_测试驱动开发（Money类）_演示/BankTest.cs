using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单元测试_测试驱动开发_Money类__演示
{
	using NUnit.Framework;

	[TestFixture]
	class BankTest
	{
		[Test]
		public void TestGetRate()
		{
			Bank bank = new Bank();
			Assert.AreEqual(0.5, bank.GetRate("CHF", "USD"));
		}
	}
}
