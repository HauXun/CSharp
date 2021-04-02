using System;
using static System.Console;

namespace Bai05
{
	class Program
	{
		static void Main(string[] args)
		{
			Date d = new Date(1, 1, 1997);
			d.display();

			d.setDate(12, 12, 2004);
			d.display();

			d.setMonth(3);
			d.display();
		}
	}

	class Date
	{
		int day;
		int month;
		int year;

		public Date(int day, int month, int year)
		{
			this.day = day;
			this.month = month;
			this.year = year;
		}

		public void setDate(int day, int month, int year)
		{
			this.day = day;
			this.month = month;
			this.year = year;
		}

		public void setDay(int day)
		{
			this.day = day;
		}
		public void setMonth(int month)
		{
			this.month = month;
		}

		public void setYear(int year)
		{
			this.year = year;
		}

		public int getDay() => day;
		public int getMonth() => month;
		public int getYear() => year;

		public void display()
		{
			string day = (this.day).ToString();
			string month = (this.month).ToString();
			string year = (this.year).ToString();
			if (day.Length == 1)
				day = "0" + day;
			if (month.Length == 1)
				month = "0" + month;
			WriteLine(day + "/" + month + "/" + year);
		}
	}
}
