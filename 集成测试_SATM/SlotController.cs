using System;
using System.Collections.Generic;
using System.Text;

namespace 集成测试_SATM
{
	internal class SlotController
	{
		public bool OpenSlot()
		{
			Console.WriteLine("Slot opened");
			return true;
		}

		public bool CloseSlot()
		{
			Console.WriteLine("Slot closed");
			return false;
		}
	}
}