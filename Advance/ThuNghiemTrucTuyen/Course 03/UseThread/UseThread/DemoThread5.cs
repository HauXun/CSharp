using System;
using System.Threading;
using static System.Console;

namespace UseThread
{
	class DemoThread5
	{
		private static int n = 100100;

		public void Demo()
		{
			// Forceground => Chương trình kết thúc phải đợi cho Thread chạy xong mới kết thúc
			// Background => Chương trình kết thúc thì Thread cũng hủy
			// 2 Thuộc tính này độ ưu tiên ngang nhau trừ khi set lại

			// Đang là Forceground => Đợi nó chạy xong rồi mới kết thúc thật sự
			Thread thread = new Thread(() =>
			{
				for (int i = 0; i < n; i++)
				{
					Write("1");
				}
			}
			);

			thread.IsBackground = true;
			thread.Start();
			WriteLine("Thread Aborted");	// Thoát chương trình
		}

		// Thực tế chạy 1 xíu nữa mới thoát
		// Cụ thể là đợi Forceground Thread chạy xong
	}
}
