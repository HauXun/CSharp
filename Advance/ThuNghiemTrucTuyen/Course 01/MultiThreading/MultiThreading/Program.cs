using System;
using System.Threading;
using static System.Console;

namespace MultiThreading
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i < 5; i++)
			{
				var valueTemp = i;
				Thread thread1 = new Thread(() =>
				{
					DemoThread("Thread " + valueTemp);
				});
				thread1.IsBackground = true;
				thread1.Start();
			}
		}

		static void DemoThread(string threadIndex)
		{
			for (int i = 0; i < 5; i++)
			{
				Thread.Sleep(TimeSpan.FromSeconds(1));
				WriteLine(threadIndex + " - " + i);
			}
		}
	}
}
