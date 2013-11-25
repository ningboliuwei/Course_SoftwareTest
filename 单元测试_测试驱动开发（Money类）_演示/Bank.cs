using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单元测试_测试驱动开发_Money类__演示
{
	class Bank
	{
		public double GetRate(string currency, string to)
		{
			if (currency == "CHF" && to == "USD")
			{
				return 0.5;
			}

			return -1;
		}
	}
}
