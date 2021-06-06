using System;
using System.Threading;
using static System.Console;

namespace UseThread
{
	class DemoThread2
	{
		// Hàm để Thread gọi. Phải là void và parameter nếu có. Phải là kiểu object
		public void Demo()
		{
			// Phải là void => ThreadState là unstarted
			Thread thread = new Thread(Print);

			int n = 5;
			string s = "Co ai muon choi zoi Tran Dan hok";

			object obj = new Tuple<string, int>(s, n);

			thread.Start(obj);  // => Running
			thread.Priority = ThreadPriority.Highest;

			/*
			ThreadState
			- Abort: Không cần biết Thread chạy xong chưa => Đưa ra 1 Exception => Kết thúc Thread
			- Suspend: Dừng cái Thread này lại => Resume() => Tiếp tục
			 */
		}

		private void Print(object s)
		{
			Tuple<string, int> tuple = s as Tuple<string, int>;
			int n = tuple.Item2;
			string str = tuple.Item1;

			for (int i = 0; i < n; i++)
			{
				WriteLine(str);
			}
		}
	}
}