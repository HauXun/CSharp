using System;
using static System.Console;

namespace Exercise_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Rectangle rec = new Rectangle();
			rec.setWidth(12);
			rec.setHeight(30);
			WriteLine("Area: {0}", rec.GetArea());
			WriteLine("Perimeter: {0}", rec.GetPerimeter());
		}
	}
}
