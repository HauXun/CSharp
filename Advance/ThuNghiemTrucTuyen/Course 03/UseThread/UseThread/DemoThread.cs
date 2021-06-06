using System;
using System.Threading;
using static System.Console;

namespace UseThread
{
	class DemoThread
	{
		private static int n = 100;

		public void Demo()
		{
			ThreadStart threadStart = new ThreadStart(MethodA);

			// Priorty => normal
			Thread thread = new Thread(threadStart);

			// Hàm để thread gọi. Phải là void và parameter nếu có. Phải là object

			thread.Start();

			//MethodA();
			MethodB();
		}

		private void MethodA()
		{
			for (int i = 0; i < n; i++)
			{
				Write("0");
			}
		}

		private void MethodB()
		{
			for (int i = 0; i < n; i++)
			{
				Write("1");
			}
		}
	}
}