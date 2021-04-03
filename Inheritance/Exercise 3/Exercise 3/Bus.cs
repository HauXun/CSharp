using System;
using static System.Console;

namespace Exercise_3
{
	class Bus : Vehicle
	{
		protected int busNumber;
		public sealed override void Out()
		{
			base.Out();
			WriteLine("Hello, This is a Bus");
		}

		public Bus(string color, int miles, int year, int busNumber) : base(color, miles, year)
		{
			this.busNumber = busNumber;
			WriteLine("Instance Constructor of Bus, " + $"busNumber = {this.busNumber}");
		}
	}
}
