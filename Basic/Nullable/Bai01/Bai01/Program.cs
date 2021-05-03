using System;
using static System.Console;

namespace Bai01
{
	class Program
	{
		static void Main(string[] args)
		{
			int? age = null;
			float? mark = null;
			Nullable<double> price = null;
			WriteLine("Age: " + age);
			WriteLine("Mark: " + (mark.HasValue ? mark.Value : 0));
			WriteLine("Price: " + (price ?? 0));
		}
	}
}
