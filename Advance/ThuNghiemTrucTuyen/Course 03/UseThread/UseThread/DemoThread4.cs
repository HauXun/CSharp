using System;
using System.Threading;
using static System.Console;

namespace UseThread
{
	class DemoThread4
	{
		private static int n = 10000;

		public void Demo()
		{
			// Priorty => normal
			Thread threadA = new Thread(new ThreadStart(MethodA));
			Thread threadB = new Thread(new ThreadStart(MethodB));
			Thread threadC = new Thread(new ThreadStart(MethodC));

			// Hàm để thread gọi. Phải là void và parameter nếu có. Phải là object

			threadA.Start();
			threadB.Start();
			threadB.Join();		// B chạy xong thì C mới được chạy

			// Những Thread nào ở dưới John này. Phải đợi thằng Thread.Join này chạy xong nó mới được chạy. Cụ thể là B

			threadC.Start();
		}

		private void MethodA()
		{
			for (int i = 0; i < n; i++)
			{
				Write("1");
			}
		}

		private void MethodB()
		{
			for (int i = 0; i < n; i++)
			{
				Write("2");
			}
		}

		private void MethodC()
		{
			for (int i = 0; i < n; i++)
			{
				Write("3");
			}
		}
	}
}
