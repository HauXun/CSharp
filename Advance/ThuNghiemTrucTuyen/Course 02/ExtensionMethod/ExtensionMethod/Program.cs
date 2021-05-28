using System;
using System.Linq;
using MyLib;
using static System.Console;

namespace ExtensionMethod
{
	// Extension Method
	class Program
	{
		static void Main(string[] args)
		{
			int[] a = { 1, 7, 4, 9, 3 };
			int max = a.Max();
			WriteLine(max);

			string s = "Xin chao Tran Dan nha";
			"Xin".Print(ConsoleColor.Red);
			"Chao".Print(ConsoleColor.Yellow);
			"Tran".Print(ConsoleColor.Magenta);
			"Dan".Print(ConsoleColor.Gray);
			"Nha".Print(ConsoleColor.Cyan);

			ResetColor();

			double b = 2.5;
			WriteLine(b.BinhPhuong());
			WriteLine(b.CanBacHai());
			WriteLine(b.Sin());
			WriteLine(b.Cos());
		}

		
	}
}
