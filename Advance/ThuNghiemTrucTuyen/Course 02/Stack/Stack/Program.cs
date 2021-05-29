using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace Stacks
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<string> hanghoa = new Stack<string>();

			hanghoa.Push("Mat hang 1");
			hanghoa.Push("Mat hang 2");
			hanghoa.Push("Mat hang 3");

			var mathang = hanghoa.Pop();
			WriteLine($"Boc do: {mathang}");

			mathang = hanghoa.Pop();
			WriteLine($"Boc do: {mathang}");

			mathang = hanghoa.Pop();
			WriteLine($"Boc do: {mathang}");
		}
	}
}
