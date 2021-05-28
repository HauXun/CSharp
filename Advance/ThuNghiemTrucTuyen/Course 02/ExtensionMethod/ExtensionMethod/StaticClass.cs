using System;
using static System.Console;

namespace ExtensionMethod
{
	// Lớp tĩnh static ~
	static class StaticClass
	{
		public static void Print(this string s, ConsoleColor color)
		{
			ForegroundColor = color;
			WriteLine(s);
		}
	}
}
