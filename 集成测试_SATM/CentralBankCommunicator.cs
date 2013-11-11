using System;
using System.Collections.Generic;
using System.Text;

namespace 集成测试_SATM
{
	internal class CentralBankCommunicator
	{
		public void SendMessage(string message, string host)
		{
			Console.WriteLine("Sending message \"{0}\" to {1}", message, host);
		}

		public string GetMessage(string host)
		{
			string message = "";

			message = "Message from: " + host;
			return message;
		}
	}
}