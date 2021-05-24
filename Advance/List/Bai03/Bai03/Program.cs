using System;
using System.Collections.Generic;
using static System.Console;

namespace Bai03
{
	class Program
	{
		static void Main(string[] args)
		{
			var fibonacciNumbers = new List<float> { 1, 1 };
			var level = 0;
			while (level < 10)
			{
				var lastNumber = fibonacciNumbers[fibonacciNumbers.Count - 1];
				var previousNumber = fibonacciNumbers[fibonacciNumbers.Count - 2];
				fibonacciNumbers.Add(lastNumber + previousNumber);
				level++;
			}
			foreach (var item in fibonacciNumbers)
			{
				Write($"{item} ");
			}
		}
	}
}
