using System;
using System.Collections.Generic;
using System.Text;

namespace 集成测试_SATM
{
	internal class DeviceController
	{
		public bool IsEverythingReady()
		{
			bool isReady = false;

			SlotController slotController = new SlotController();

			bool slotIsOpened = false;
			slotIsOpened = slotController.OpenSlot();

			SessionManager manager = new SessionManager();
			bool sessionIsValid = false;

			sessionIsValid = manager.IsValid();
			if (sessionIsValid == true && slotIsOpened)
			{
				isReady = true;
			}
			else
			{
				isReady = false;
			}
			return isReady;
		}
	}
}