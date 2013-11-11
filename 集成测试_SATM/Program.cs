using System;
using System.Collections.Generic;
using System.Text;

namespace 集成测试_SATM
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("Welcome to use SATM...");
			CentralBankCommunicator communicator = new CentralBankCommunicator();
			communicator.SendMessage("send message", "10.22.149.99");
			Console.WriteLine(communicator.GetMessage("10.22.149.99"));

			bool sessionIsValid = false;
			bool deviceIsValid = false;

			SessionManager manager = new SessionManager();
			sessionIsValid = manager.IsValid();

			DeviceController controller = new DeviceController();
			deviceIsValid = controller.IsEverythingReady();


			if (sessionIsValid == true && deviceIsValid == true)
			{
				Console.WriteLine("You can withdraw money now");
			}
			//(new CardValidatorDriver()).Test();

			Console.ReadLine();
		}
	}
}