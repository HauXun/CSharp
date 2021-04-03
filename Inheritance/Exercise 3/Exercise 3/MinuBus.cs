using System;
using static System.Console;

namespace Exercise_3
{
	class MinuBus : Bus
	{
		public MinuBus(string color, int miles, int year, int busNumber) : base(color, miles, year, busNumber)
		{
			WriteLine("Initialize MiniBus Object");
		}

		//public override void Out()
		//{
		//	base.Out();
		//}
	}
}
