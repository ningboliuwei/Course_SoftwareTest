using System;
using System.Collections.Generic;
using System.Text;

namespace 集成测试_SATM
{
	class CardValidatorDriver
	{
		public void Test()
		{
			CardValidator cardValidator = new CardValidator();
			Console.WriteLine(cardValidator.GetCardNumber());
		}
	}
}
