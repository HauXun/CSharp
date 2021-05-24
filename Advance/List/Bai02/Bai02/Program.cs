using System;
using System.Collections.Generic;
using static System.Console;

namespace Bai02
{
	class Program
	{
		static void Main(string[] args)
		{
			var animals = new List<string> { "cat", "dog", "dinosar", "tiger" };
			animals.Add("lion");
			foreach (var item in animals)
			{
				WriteLine($"Hello {item.ToUpper()}");
			}
			  
			WriteLine($"animals[1] = {animals[1]}");
			var indexOfLion = animals.IndexOf("lion");
			WriteLine($"indexOfLion = {indexOfLion}");
			if (indexOfLion < 0)
			{
				WriteLine("Cannot find \"lion\" in the list !");
			}
			else
				WriteLine($"Found lion at index = {indexOfLion}");
			animals.Sort();
			animals.Reverse();
			foreach (var item in animals)
			{
				WriteLine($"{item}");
			}
			WriteLine($"animals has {animals.Count} elements");
		}
	}
}
