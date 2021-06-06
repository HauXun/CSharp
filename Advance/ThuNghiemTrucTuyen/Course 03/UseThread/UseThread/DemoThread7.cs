using System;
using System.Threading;
using static System.Console;

namespace UseThread
{
	class DemoThread7
	{
		private static int amount = 0;
		object key = new object();

		public void Demo()
		{
			Thread thread1 = new Thread(IncreaseAmount);
			Thread thread2 = new Thread(DecreaseAmount);

			thread1.Start();
			thread2.Start();
			ReadLine();
		}

		private void IncreaseAmount()
		{
			for (int i = 0; i < 100; i++)
			{
				lock (key)
				{
					amount++;
					if (amount > 0)
					{
						Thread.Sleep(1);
						Write(amount + '\t');
					}
				}
			}
		}

		private void DecreaseAmount()
		{
			for (int i = 0; i < 100; i++)
			{
				lock (key)
				{
					amount--;
				}
			}
		}
	}
}
