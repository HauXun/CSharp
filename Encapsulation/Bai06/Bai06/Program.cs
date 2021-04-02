using System;
using static System.Console;

namespace Bai06
{
	class Program
	{
		static void Main(string[] args)
		{
			Time t = new Time(12, 1, 1);
			t.display();
			t.setTime(23, 59, 59);
			t.display();
			t.nextSecond();
			t.display();
			t.nextSecond();
			t.display();
			t.setTime(7, 0, 0);
			t.display();
			t.previousSecond();
			t.display();
		}

		class Time
		{
			int hour;
			int minute;
			int second;

			public Time(int hour, int minute, int second)
			{
				this.hour = hour;
				this.minute = minute;
				this.second = second;
			}

			public void setTime(int hour, int minute, int second)
			{
				this.hour = hour;
				this.minute = minute;
				this.second = second;
			}

			public void setHour(int hour)
			{
				this.hour = hour;
			}

			public void setMinute(int minute)
			{
				this.minute = minute;
			}

			public void setSecond(int second)
			{
				this.second = second;
			}

			public int getHour() => hour;
			public int getMinute() => minute;
			public int getSecond() => second;

			public void nextSecond()
			{
				if (hour == 23 && minute == 59 && second == 59)
				{
					hour = 0;
					minute = 0;
					second = 0;
					return;
				}
				if (minute == 59 && second == 59)
				{
					hour++;
					minute = 0;
					second = 0;
				}
				if (second == 59)
				{
					minute++;
					second = 0;
					return;
				}
				second++;
			}

			public void previousSecond()
			{
				if (hour == 0 && minute == 0 && second == 0)
				{
					hour = 23;
					minute = 59;
					second = 59;
					return;
				}
				if (minute == 0 && second == 0)
				{
					hour--;
					minute = 59;
					second = 59;
					return;
				}
				if (second == 0)
				{
					minute--;
					second = 59;
					return;
				}
				second--;
			}

			public void display()
			{
				string hour = (this.hour).ToString();
				string minute = (this.minute).ToString();
				string second = (this.second).ToString();
				if (hour.Length == 1)
					hour = "0" + hour;
				if (minute.Length == 1)
					minute = "0" + minute;
				if (second.Length == 1)
					second = "0" + second;
				WriteLine(hour + ":" + minute + ":" + second);
			}
		}
	}
}
