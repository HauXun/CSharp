using System;

namespace Static
{
	class CountNumber
	{
		public static int number = 0;
		public static void Info() => Console.WriteLine("So lan truy cap: " + number);

		public void Count() => CountNumber.number++;
	}
}
