using System;
using System.Threading;
using static System.Console;

namespace UseThread
{
	class DemoThread3
	{
		private static int n = 100000;
		public void Demo()
		{
			ThreadStart threadStart = new ThreadStart(MethodA);

			// Priorty => normal
			Thread thread = new Thread(threadStart);

			// Hàm để thread gọi. Phải là void và parameter nếu có. Phải là object

			thread.Start();

			//MethodA();
			MethodB();

			thread.Abort();		// Sau khi MethodB chạy xong. Không cần biết Thread đã chạy xong chưa => Thread đều bị hủy
		}

		private void MethodA()
		{
			Thread.Sleep(2000);		// Ngưng 2s
			for (int i = 0; i < n; i++)
			{
				Write("@");
			}
		}

		private void MethodB()
		{
			for (int i = 0; i < n; i++)
			{
				Write("|");
			}
		}
	}
}
