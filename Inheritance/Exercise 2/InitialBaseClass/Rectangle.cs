using System;
using static System.Console;

namespace InitialBaseClass
{
	class Rectangle
	{
		protected int width;
		protected int height;

		public Rectangle(int width, int height)
		{
			this.width = width;
			this.height = height;
		}

		public double GetArea() => width * height;

		public void Display()
		{
			WriteLine("Width: {0}", width);
			WriteLine("Height: {0}", height);
			WriteLine("Area: {0}", GetArea());
		}
	}
}
