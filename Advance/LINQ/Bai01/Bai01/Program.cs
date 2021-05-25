using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace Bai01
{
	class Program
	{
		static IEnumerable<string> ReadFrom(string fileName)
		{
			var reader = File.OpenText(fileName);
			WriteLine($"Type of reader = {reader.GetType()}");
			string eachLine;
			while ((eachLine = reader.ReadLine()) != null)
			{
				yield return eachLine;
			}
		}

		static void Main(string[] args)
		{
			var lines = ReadFrom("textFile.txt");
			var points = new List<Point>();

			foreach (var line in lines)
			{
				//WriteLine(line);
				var numbers = line.Split(new[] { ", " }, StringSplitOptions.None);
				var x = Convert.ToDouble(numbers[0]);
				var y = Convert.ToDouble(numbers[1]);

				//WriteLine($"x = {x}, y = {y}");

				var newPoint = new Point(x, y);
				points.Add(newPoint);
			}
			WriteLine("List of points");
			foreach (var point in points)
			{
				point.ShowInfo();
			}
		}
	}
}
