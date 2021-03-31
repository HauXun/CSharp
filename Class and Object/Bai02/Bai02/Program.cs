using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
	class Rectangle
	{
		public double width;
		public double length;

		public void getInformation()
		{
			width = double.Parse(Console.ReadLine());
			length = double.Parse(Console.ReadLine());
		}

		public double getArea()
		{
			return width * length;
		}

		public double getPerimeter()
		{
			return (width + length) * 2;
		}

		public void Display()
		{
			Console.WriteLine("Area: " + getArea());
			Console.WriteLine("Perimeter: " + getPerimeter());
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Rectangle r1 = new Rectangle();
			r1.getInformation();
			r1.Display();
			Console.ReadLine();
		}
	}
}
