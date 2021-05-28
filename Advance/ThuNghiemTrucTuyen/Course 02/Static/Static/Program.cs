using System;
using static System.Console;

namespace Static
{
	class Program
	{
		static void Main(string[] args)
		{
			CountNumber.Info();
			WriteLine($"{CountNumber.number.GetType()}: {CountNumber.number}");

			CountNumber number1 = new CountNumber();
			CountNumber number2 = new CountNumber();

			number1.Count();
			number2.Count();
			CountNumber.Info();
		}
	}
}
