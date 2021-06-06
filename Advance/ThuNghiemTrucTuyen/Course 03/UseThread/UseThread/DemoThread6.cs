using System;
using System.Threading;
using static System.Console;

namespace UseThread
{
	class DemoThread6
	{
		private static int n = 10;

		public void Demo()
		{
			// Hàm của Thread pool phải có parameter
			ThreadPool.QueueUserWorkItem(MethodB, "Lan 1");
			ThreadPool.QueueUserWorkItem(MethodA, "Lan 2");
			ReadLine();
		}

		private void MethodA(object s)
		{
			for (int i = 0; i < n; i++)
			{
				WriteLine(s);
				Thread.Sleep(500);
			}
		}

		private void MethodB(object s)
		{
			for (int i = 0; i < n; i++)
			{
				WriteLine(s);
				Thread.Sleep(500);
			}
		}
	}
}
