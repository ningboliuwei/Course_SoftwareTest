using System;
using System.Collections.Generic;
using System.Text;

namespace 集成测试_SATM
{
	internal class SessionManager
	{
		public bool IsValid()
		{
			bool result = false;

			CardValidator cardValidator = new CardValidator();
			string cardNumber = cardValidator.GetCardNumber();
			string pin = GetPIN();

			if (cardNumber == "123456"
			    && pin == "pass")
			{
				result = true;
			}
			else
			{
				result = false;
			}

			return result;
		}

		public string GetPIN()
		{
			return "pass";
		}
	}
}