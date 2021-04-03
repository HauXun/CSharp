using System;
using static System.Console;

namespace Exercise_2
{
	class Shape
	{
		protected int width;
		protected int height;

		public void setWidth(int width)
		{
			this.width = width;
		}

		public void setHeight(int height)
		{
			this.height = height;
		}
		
	}
	class Rectangle : Shape
	{
		public int GetArea() => width * height;
	}

	class Program
	{
		static void Main(string[] args)
		{
			Rectangle rec = new Rectangle();
			rec.setWidth(12);
			rec.setHeight(30);
			WriteLine("Area: {0}", rec.GetArea());
		}
	}
}
