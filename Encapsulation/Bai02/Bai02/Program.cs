using System;
using static System.Console;

namespace Bai02
{
	class Program
	{
		static void Main(string[] args)
		{
			Rectangle r = new Rectangle(4, 5);
			WriteLine("Area: " + r.getArea());
			WriteLine("Perimeter: " + r.getPerimeter());

			r.setLength(2);
			r.setWidth(3);
			WriteLine("Area: " + r.getArea());
			WriteLine("Perimeter: " + r.getPerimeter());
		}
	}

	class Rectangle
	{
		private double length;
		private double width;

		public Rectangle()
		{

		}

		public Rectangle(double length, double width)
		{
			this.length = length;
			this.width = width;
		}

		public double getLength() => length;
		public double getWidth() => width;

		public void setLength(double length)
		{
			this.length = length;
		}
		public void setWidth(double width)
		{
			this.width = width;
		}

		public double getArea() => length * width;
		public double getPerimeter() => (length + width) / 2;
	}
}
