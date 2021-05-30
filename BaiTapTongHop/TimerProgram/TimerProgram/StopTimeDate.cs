using System;
using static System.Console;

namespace TimerProgram
{
	class StopTimeDate
	{
		DateTime oldTime;
		DateTime newTime;
		TimeSpan currentTime;
		bool isResume = true;

		public StopTimeDate()
		{
			oldTime = DateTime.Now;
			newTime = DateTime.Now;
		}

		public void Start()
		{
			oldTime = DateTime.Now;
			Count();
		}

		public void Reset()
		{
			oldTime = DateTime.Now;
		}

		public void Pause()
		{
			isResume = !isResume;
		}

		public void Show(int x, int y)
		{
			SetCursorPosition(x, y);
			WriteLine($"{currentTime.Minutes} phut {currentTime.Seconds} giay");
		}

		public void Count()
		{
			if (!isResume)
				return;
			newTime = DateTime.Now;
			currentTime = newTime - oldTime;
		}
	}
}
