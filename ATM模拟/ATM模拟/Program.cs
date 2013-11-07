namespace ATM模拟
{
	using System;
	using System.Windows.Forms;

	internal static class Program
	{
		#region Methods

		/// <summary>
		///     应用程序的主入口点。
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}

		#endregion
	}
}