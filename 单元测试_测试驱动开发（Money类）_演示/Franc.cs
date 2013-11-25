using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单元测试_测试驱动开发_Money类__演示
{
	class Franc : Money
	{
		public Franc()
			: base()
		{
			m_currency = "CHF";
		}

		public Franc(double amount)
			: base(amount)
		{
			m_currency = "CHF";
		}

	}
}

