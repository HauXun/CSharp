using System;
using System.Threading;
using static System.Console;

namespace TimerProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			StopTimeDate();
		}

		static void StopTimeDate()
		{
			StopTimeDate stopWatch = new StopTimeDate();

			stopWatch.Start();
			while (true)
			{
				Thread.Sleep(10);
				stopWatch.Count();
				stopWatch.Show(50, 50);
			}
		}

		static void StopWatch()
		{
			StopTime stopWatch = new StopTime();

			int count = 0;
			int sleepTime = 1;
			int showTime = 1000;

			// Bấm SpaceBar thì tạm dừng và ngược lại
			while (true)
			{
				Thread.Sleep(sleepTime);

				// Nếu user nhấn phím
				if (KeyAvailable)
				{
					ConsoleKeyInfo key = ReadKey();
					if (key.Key.Equals(ConsoleKey.R))
					{
						stopWatch.ResetTime();
					}
					if (key.Key.Equals(ConsoleKey.Spacebar))
					{
						stopWatch.PauseTime();
					}
				}
				if (count % (showTime) == 0)
				{
					stopWatch.CountTime();
					stopWatch.ShowTime(50, 50);
				}
				count += sleepTime;
			}
		}
	}
}