using System;
using static System.Console;

namespace Exercise_3
{
	class Vehicle
	{
		public string color;
		protected int miles;
		protected int year;

		public Vehicle(string color, int miles, int year)
		{
			this.color = color;
			this.miles = miles;
			this.year = year;

			WriteLine("Instance Constructor of Vehicle, " + $"Color = {this.color} ", $"Miles = {this.miles}", $"Year = {this.year}");
		}

		public static long productionDate;
		static Vehicle()
		{
			WriteLine("This is a Static Constructor");
			//this.miles = 100; // Cannot access instance property from static constructor
			productionDate = DateTime.Now.Ticks;
		}

		public virtual void Out()
		{
			WriteLine("Hello, This is a Vehicle");
		}
	}
}
