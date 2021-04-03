using System;
using static System.Console;

namespace Exercise_3
{
	class Program
	{
		static void Main(string[] args)
		{
			//var vehicle = new Vehicle("Red", 1200, 2017);
			//vehicle.color = "Red";
			//vehicle.Out();
			var bus = new Bus("Green", 1300, 2018, 20);
			WriteLine($"Vehicle.productionDate = {Bus.productionDate}");
			//bus.Out();
		}
	}
}
