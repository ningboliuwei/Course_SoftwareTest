﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单元测试_测试驱动开发_Money类__演示
{
	class Dollar : Money
	{
		public Dollar()
			: base()
		{
			m_currency = "USD";
		}

		public Dollar(double amount)
			: base(amount)
		{
			m_currency = "USD";
		}
	}
}
